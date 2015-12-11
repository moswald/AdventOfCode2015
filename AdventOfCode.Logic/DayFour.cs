namespace AdventOfCode.Logic
{
    using System.Diagnostics;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using AdventOfCode.Logic.Extensions;

    public class DayFour
    {
        readonly MD5 _md5 = MD5.Create();

        public int MineAdventCoin(string key)
        {
            return Alg.Infinity()
                .First(num => HashHelper(key, num));
        }

        bool HashHelper(string key, int number)
        {
            return _md5.ComputeHash(Encoding.UTF8.GetBytes(key + number))
                .TakeWhile((b, idx) => idx == 2 ? b <= 0xf : b == 0)
                .Take(3)
                .Count() == 3;
        }
    }
}
