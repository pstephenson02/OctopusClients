
namespace Octopus.Client.Model
{
    public enum MachineScriptPolicyRunType : int
    {
        InheritFromDefault = 0,
        Inline,
        OnlyConnectivity
    }

    public class MachineScriptPolicy
    {
        public MachineScriptPolicyRunType RunType { get; set; }
        public string PowershellScript { get; set; }
        public string BashScript { get; set; }
        public string CSharpScript { get; set; }
        public string FSharpScript { get; set; }
    }
}
