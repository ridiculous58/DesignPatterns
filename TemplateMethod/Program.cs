using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Ayni methodların farklı yerde farklı sonuclar uretmesi
    class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm scoringAlgorithm;
            Console.WriteLine("Mans");
            scoringAlgorithm = new MensScoringAlgorithm();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10,new TimeSpan(0,2,34)));
            Console.WriteLine("Woman");
            scoringAlgorithm = new WomanScoringAlgorithm();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));
            Console.WriteLine("Children");
            scoringAlgorithm = new ChildrenScoringAlgorithm();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));
            Console.ReadLine();
        }
    }

    abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits,TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        protected abstract int CalculateOverallScore(int score, int reduction);

        protected abstract int CalculateReduction(TimeSpan time);

        protected abstract int CalculateBaseScore(int hits);
    }

    class MensScoringAlgorithm : ScoringAlgorithm
    {
        protected override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        protected override int CalculateReduction(TimeSpan time)
        {
            return (int) time.TotalSeconds / 5;
        }

        protected override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }
    }

    class WomanScoringAlgorithm : ScoringAlgorithm
    {
        protected override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        protected override int CalculateReduction(TimeSpan time)
        {
            return (int) time.TotalSeconds / 3;
        }

        protected override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }
    }

    class ChildrenScoringAlgorithm : ScoringAlgorithm
    {
        protected override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        protected override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        protected override int CalculateReduction(TimeSpan time)
        {
            return (int) time.TotalSeconds / 2;
        }
    }
}
