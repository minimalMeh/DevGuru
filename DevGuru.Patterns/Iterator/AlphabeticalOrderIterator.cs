namespace DevGuru.Patterns.Iterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private readonly WordsCollection wordsCollection;
        private int position = -1;
        private readonly bool reverse = false;

        public AlphabeticalOrderIterator(WordsCollection wordsCollection, bool reverse = false)
        {
            this.wordsCollection = wordsCollection;
            this.reverse = reverse;

            if (reverse)
            {
                position = wordsCollection.Count;
            }
        }

        public override string Current => wordsCollection[position];

        public override bool MoveNext()
        {

            int updatedPosition = position + (reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < wordsCollection.Count)
            {
                position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            position = reverse ? wordsCollection.Count - 1 : 0;
        }
    }
}
