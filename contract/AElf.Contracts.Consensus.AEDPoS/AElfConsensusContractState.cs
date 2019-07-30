using AElf.Sdk.CSharp.State;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.Consensus.AEDPoS
{
    public partial class AEDPoSContractState : ContractState
    {
        public BoolState Initialized { get; set; }

        /// <summary>
        /// Seconds.
        /// </summary>
        public Int64State TimeEachTerm { get; set; }

        public Int64State CurrentRoundNumber { get; set; }

        public Int64State CurrentTermNumber { get; set; }

        public SingletonState<Timestamp> BlockchainStartTimestamp { get; set; }

        // TODO: Just keep necessary rounds.
        public MappedState<long, Round> Rounds { get; set; }

        public Int32State MiningInterval { get; set; }

        public MappedState<long, long> FirstRoundNumberOfEachTerm { get; set; }

        public MappedState<long, MinerList> MinerListMap { get; set; }

        public Int64State MainChainRoundNumber { get; set; }

        public SingletonState<MinerList> MainChainCurrentMinerList { get; set; }

        public BoolState IsMainChain { get; set; }

        public Int64State MinerIncreaseInterval { get; set; }
    }
}