﻿namespace NHSE.Injection
{
    public enum RWMethod // from LiveHeX
    {
        Heap,
        Main,
        Absolute
    }

    public interface IRAMReadWriter
    {
        int MaximumTransferSize { get; }
        bool Connected { get; }
        byte[] ReadBytes(ulong offset, int length, RWMethod method = RWMethod.Heap);
        void WriteBytes(byte[] data, ulong offset, RWMethod method = RWMethod.Heap);
        byte[] GetVersion();
        ulong FollowMainPointer(long[] jumps);
        void FreezeBytes(byte[] data, uint offset);
        void UnFreezeBytes(uint offset);
        byte GetFreezeCount();
        void UnfreezeAll();
    }
}