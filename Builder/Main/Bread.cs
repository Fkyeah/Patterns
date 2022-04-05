﻿using Builder.Components;
using System.Text;

namespace Builder.Main
{
    public class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (Flour != null)
                sb.Append(Flour.Sort + "\n");

            if (Salt != null)
                sb.Append("Соль \n");

            if (Additives != null)
                sb.Append(string.Format("Добавки: {0} \n", Additives.Name));

            return sb.ToString();
        }
    }
}
