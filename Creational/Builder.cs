namespace Creational
{
    public static class Builder
    {
        public static void Execute(string[] args)
        {
            var bodyBuilder = new BodyBuilder();

            // Fluent Builder
            bodyBuilder.WithArms(2)
                .WithLegs(2)
                .WithHeads(1)
                .WithTails(1)
                .WithWings(2)
                .WithTeeths(32);

            Console.WriteLine(bodyBuilder);

            bodyBuilder.RemoveTails(1);
            bodyBuilder.RemoveWings(2);

            Console.WriteLine(bodyBuilder);

            Console.ReadKey();
        }
    }

    public class BodyBuilder
    {
        private int _legs;
        private int _arms;
        private int _heads;
        private int _tails;
        private int _wings;
        private int _teeths;

        public BodyBuilder()
        {
            _legs = 0;
            _arms = 0;
            _heads = 0;
            _tails = 0;
            _wings = 0;
            _teeths = 0;
        }

        public BodyBuilder(int legs, int arms, int heads, int tails, int wings, int teeths)
        {
            _legs = legs;
            _arms = arms;
            _heads = heads;
            _tails = tails;
            _wings = wings;
            _teeths = teeths;
        }

        public int Legs
        {
            get { return _legs; }
        }

        public int Arms
        {
            get { return _arms; }
        }

        public int Heads
        {
            get { return _heads; }
        }

        public int Tails
        {
            get { return _tails; }
        }

        public int Wings
        {
            get { return _wings; }
        }

        public int Teeths
        {
            get { return _teeths; }
        }

        public override string ToString()
        {
            return string.Format("Legs: {0}, Arms: {1}, Heads: {2}, Tails: {3}, Wings: {4}, Teeths: {5}", _legs, _arms, _heads, _tails, _wings, _teeths);
        }

        #region Base Builder Methods

        public void AddLegs(int legs)
        {
            _legs += legs;
        }

        public void AddArms(int arms)
        {
            _arms += arms;
        }

        public void AddHeads(int heads)
        {
            _heads += heads;
        }

        public void AddTails(int tails)
        {
            _tails += tails;
        }

        public void AddWings(int wings)
        {
            _wings += wings;
        }

        public void AddTeeths(int teeths)
        {
            _teeths += teeths;
        }

        public void RemoveLegs(int legs)
        {
            _legs -= legs;
        }

        public void RemoveArms(int arms)
        {
            _arms -= arms;
        }

        public void RemoveHeads(int heads)
        {
            _heads -= heads;
        }

        public void RemoveTails(int tails)
        {
            _tails -= tails;
        }

        public void RemoveWings(int wings)
        {
            _wings -= wings;
        }

        public void RemoveTeeths(int teeths)
        {
            _teeths -= teeths;
        }

        #endregion Base Builder Methods

        #region Fluent Builder Methods

        public BodyBuilder WithLegs(int legs)
        {
            _legs += legs;
            return this;
        }

        public BodyBuilder WithArms(int arms)
        {
            _arms += arms;
            return this;
        }

        public BodyBuilder WithHeads(int heads)
        {
            _heads += heads;
            return this;
        }

        public BodyBuilder WithTails(int tails)
        {
            _tails += tails;
            return this;
        }

        public BodyBuilder WithWings(int wings)
        {
            _wings += wings;
            return this;
        }

        public BodyBuilder WithTeeths(int teeths)
        {
            _teeths += teeths;
            return this;
        }

        public BodyBuilder WithoutLegs(int legs)
        {
            _legs -= legs;
            return this;
        }

        public BodyBuilder WithoutArms(int arms)
        {
            _arms -= arms;
            return this;
        }

        public BodyBuilder WithoutHeads(int heads)
        {
            _heads -= heads;
            return this;
        }

        public BodyBuilder WithoutTails(int tails)
        {
            _tails -= tails;
            return this;
        }

        public BodyBuilder WithoutWings(int wings)
        {
            _wings -= wings;
            return this;
        }

        public BodyBuilder WithoutTeeths(int teeths)
        {
            _teeths -= teeths;
            return this;
        }

        #endregion Fluent Builder Methods
    }
}