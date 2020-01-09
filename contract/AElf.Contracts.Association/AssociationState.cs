using AElf.Sdk.CSharp.State;
using AElf.Types;
using Acs1;
using Acs3;

namespace AElf.Contracts.Association
{
    public partial class AssociationState : ContractState
    {
        public MappedState<Address, Organization> Organisations { get; set; }
        public MappedState<Hash, ProposalInfo> Proposals { get; set; }
        public MappedState<string, MethodFees> TransactionFees { get; set; }
        public SingletonState<AuthorityStuff> MethodFeeController { get; set; }
    }
}