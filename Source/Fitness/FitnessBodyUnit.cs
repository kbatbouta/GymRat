#region

using Verse;

#endregion

namespace PumpingSteel.Fitness
{
    public class FitnessBodyUnit : IFitnessUnit
    {
        public FitnessBodyUnit()
        {
        }

        public FitnessBodyUnit(Pawn pawn) : base(pawn)
        {
        }

        public override string LoadPostfix => "fitness";

        public override void ExposeData()
        {
            base.ExposeData();
        }
    }
}