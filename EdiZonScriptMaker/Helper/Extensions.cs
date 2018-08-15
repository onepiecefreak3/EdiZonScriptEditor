using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdiZonScriptMaker
{
    public static class Extensions
    {
        public static bool IsNumeric(this string value) => int.TryParse(value, out int n);

        public static bool IsHexNumeric(this string value)
        {
            try
            {
                Convert.ToInt32(value, 16);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static IEnumerable<DataGridViewRow> Where(this DataGridViewRowCollection rows, Func<DataGridViewRow, bool> func)
        {
            foreach (DataGridViewRow r in rows)
                if (func(r))
                    yield return r;
        }

        public static IEnumerable<T> Select<T>(this DataGridViewSelectedCellCollection cells, Func<DataGridViewCell, T> func)
        {
            foreach (DataGridViewCell c in cells)
                yield return func(c);
        }
    }
}
