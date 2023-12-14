using System.Collections.Generic;

namespace DevGuru.Core.Builder
{
    public class Bread
    {
        public string Flour { get; set; }
        public double Salt { get; set; }
        public double Weight { get; set; }
        public HashSet<string> Supplements { get; } = new HashSet<string>();

        public override string ToString() =>
            $"\n\tBread Description:\n\tFlour: {Flour};\n\tSalt: {Salt}gr;\n\tWeight: {Weight}gr;\n\tSupplements: {(Supplements.Count > 0 ? string.Join(", ", Supplements) : "-")};\n";
    }
}
