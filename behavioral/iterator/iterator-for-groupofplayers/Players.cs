using System.Collections;

namespace Players
{
    class Clan : IEnumerable
    {
        private Player[] _players;
        private string _name;

        int Count
        { 
            get { return _players.Length; } 
        }

        public Clan(string name, List<Player> members)
        {
            this._name = name;
            this._players = members.ToArray();
        }

        /* Implementation for the GetEnumerator method. */
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public ClanEnum GetEnumerator()
        {
            return new ClanEnum(_players);
        }

    }

    class ClanEnum : IEnumerator
    {
        public Player[] _players;

        /* Enumerators are positioned before the first element until the first MoveNext() call. */
        int position = -1;

        public ClanEnum(Player[] members)
        {
            this._players = members;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _players.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current 
        { 
            get { return Current; } 
        }

        public Player Current
        {
            get
            {
                try { return _players[position]; }
                catch(IndexOutOfRangeException) { throw new InvalidOperationException(); }
            }
        }
    }

}
