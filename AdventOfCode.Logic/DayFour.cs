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

        public int MineAdventCoin(string key, int startingZeroes)
        {
            return Alg.Infinity()
                .First(num => HashHelper(key, num, startingZeroes));
        }

        bool HashHelper(string key, int number, int startingZeroes)
        {
            var allZero = (startingZeroes % 2) == 0;
            var count = (startingZeroes + 1) / 2;
            return _md5.ComputeHash(Encoding.UTF8.GetBytes(key + number))
                .Take(count)
                .Select(
                    (b, idx) =>
                    {
                        if (allZero || (idx < count - 1))
                        {
                            return b == 0;
                        }

                        return b <= 0xf;
                    })
                .Count(b => b) == 3;
        }
    }
}
