﻿using System;
using System.Runtime.InteropServices;

namespace Discord.Audio
{
    internal unsafe class OpusEncoder : OpusConverter
    {
        [DllImport("opus", EntryPoint = "opus_encoder_create", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr CreateEncoder(int Fs, int channels, int application, out OpusError error);
        [DllImport("opus", EntryPoint = "opus_encoder_destroy", CallingConvention = CallingConvention.Cdecl)]
        private static extern void DestroyEncoder(IntPtr encoder);
        [DllImport("opus", EntryPoint = "opus_encode", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Encode(IntPtr st, byte* pcm, int frame_size, byte* data, int max_data_bytes);
        [DllImport("opus", EntryPoint = "opus_encoder_ctl", CallingConvention = CallingConvention.Cdecl)]
        private static extern int EncoderCtl(IntPtr st, OpusCtl request, int value);
        
        /// <summary> Gets the coding mode of the encoder. </summary>
        public OpusApplication Application { get; }

        public OpusEncoder(int samplingRate, int channels, OpusApplication application = OpusApplication.MusicOrMixed)
            : base(samplingRate, channels)
        {
            Application = application;

            OpusError error;
            _ptr = CreateEncoder(samplingRate, channels, (int)application, out error);
            if (error != OpusError.OK)
                throw new Exception($"Opus Error: {error}");
        }

        /// <summary> Produces Opus encoded audio from PCM samples. </summary>
        /// <param name="input">PCM samples to encode.</param>
        /// <param name="output">Buffer to store the encoded frame.</param>
        /// <returns>Length of the frame contained in outputBuffer.</returns>
        public unsafe int EncodeFrame(byte[] input, int inputOffset, int inputCount, byte[] output, int outputOffset)
        {
            int result = 0;
            fixed (byte* inPtr = input)
            fixed (byte* outPtr = output)
                result = Encode(_ptr, inPtr + inputOffset, inputCount / SampleSize, outPtr + outputOffset, output.Length - outputOffset);

            if (result < 0)
                throw new Exception($"Opus Error: {(OpusError)result}");
            return result;
        }

        /// <summary> Gets or sets whether Forward Error Correction is enabled. </summary>
        public void SetForwardErrorCorrection(bool value)
        {
            var result = EncoderCtl(_ptr, OpusCtl.SetInbandFECRequest, value ? 1 : 0);
            if (result < 0)
                throw new Exception($"Opus Error: {(OpusError)result}");
        }

        /// <summary> Gets or sets whether Forward Error Correction is enabled. </summary>
        public void SetBitrate(int value)
        {
            if (value < 1 || value > DiscordVoiceAPIClient.MaxBitrate)
                throw new ArgumentOutOfRangeException(nameof(value));

            var result = EncoderCtl(_ptr, OpusCtl.SetBitrateRequest, value * 1000);
            if (result < 0)
                throw new Exception($"Opus Error: {(OpusError)result}");
        }

        protected override void Dispose(bool disposing)
        {
            if (_ptr != IntPtr.Zero)
            {
                DestroyEncoder(_ptr);
                _ptr = IntPtr.Zero;
            }
        }
    }
}
