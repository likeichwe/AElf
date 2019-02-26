using AElf.Common;
using AElf.Kernel;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Sdk.CSharp
{
    public interface IConsensusSmartContract : ISmartContract
    {
        ValidationResult ValidateConsensus(byte[] consensusInformation);
        IMessage GetNewConsensusInformation(byte[] extraInformation);

        TransactionList GenerateConsensusTransactions(ulong preBlockHeight, byte[] preBlockPrefix,
            byte[] extraInformation);
        IMessage GetConsensusCommand(Timestamp timestamp, string publicKey);
    }
}