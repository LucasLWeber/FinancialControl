using System.ComponentModel;

namespace FinancialControl.Domain.Enums
{
    public enum Operation
    {
        [Description("Representa uma operação de entrada")]
        In = 1,
        [Description("Representa uma operação de saída")]
        Out = 2
    }
}
