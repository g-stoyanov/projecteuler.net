namespace ProjectEulerDotNetProblems.Utilities
{
    public class FibonacciSequence
    {
        private ulong first;
        private ulong second;
        private ulong current;
        private uint currentPositionInSequence;

        public FibonacciSequence()
        {
            this.first = 0;
            this.second = 1;
            this.current = 1;
            this.currentPositionInSequence = 1;
        }

        public void Reset()
        {
            this.first = 0;
            this.second = 1;
            this.current = 1;
            this.currentPositionInSequence = 1;
        }

        public uint GetCurrentPositionInSequence()
        {
            return this.currentPositionInSequence;
        }

        public ulong GetNext()
        {
            currentPositionInSequence++;
            if (currentPositionInSequence > 3)
            {
                ulong next = this.second + this.current;
                this.first = this.second;
                this.second = this.current;
                this.current = next;

                return this.current;
            }
            else if (currentPositionInSequence > 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public ulong GetPrevious()
        {
            currentPositionInSequence--;
            if (currentPositionInSequence > 3)
            {
                ulong last = this.current - this.second;
                this.current = this.second;
                this.second = this.first;
                this.first = last;

                return this.current;
            }
            else if (currentPositionInSequence > 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public ulong GetCurrent()
        {
            if (currentPositionInSequence > 3)
            {
                return this.current;
            }
            else if (currentPositionInSequence > 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
