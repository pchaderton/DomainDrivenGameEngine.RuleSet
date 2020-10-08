using System;

namespace DomainDrivenGameEngine.RuleSet.Demo
{
    /// <summary>
    /// An example class demonstrating the expected style as enforced by the ruleset defined in DomainDrivenGameEngine.RuleSet.
    /// </summary>
    public class RuleSetExample
    {
        /// <summary>
        /// The meaning of life.
        /// </summary>
        private const int MeaningOfLife = 42;

        /// <summary>
        /// The counter for maintaining the next ID.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// The ID of this instance.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSetExample"/> class.
        /// </summary>
        public RuleSetExample()
        {
            _id = ++_idCounter;
        }

        /// <summary>
        /// Gets the ID of this instance.
        /// </summary>
        public int Id { get => _id; }

        /// <summary>
        /// Prints an example value.
        /// </summary>
        public void PrintExample()
        {
            Console.WriteLine(MeaningOfLife);
        }
    }
}
