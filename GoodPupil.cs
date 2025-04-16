using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study() => Console.WriteLine($"{LastName} учится хорошо.");
        public override void Read() => Console.WriteLine($"{LastName} читает хорошо.");
        public override void Write() => Console.WriteLine($"{LastName} пишет аккуратно.");
        public override void Relax() => Console.WriteLine($"{LastName} отдыхает.");
    }
}
