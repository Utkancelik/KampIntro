using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKeys, TValues>
    {
        private TKeys[] _tKeysArray;
        private TValues[] _tValuesArray;

        public MyDictionary()
        {
            _tKeysArray = new TKeys[0];
            _tValuesArray = new TValues[0];
        }

        public void Add(TKeys key, TValues value)
        {
            TKeys[] _tempKeysArray;
            TValues[] _tempValuesArray;

            _tempValuesArray = _tValuesArray;
            _tempKeysArray = _tKeysArray;

            _tValuesArray = new TValues[_tValuesArray.Length + 1];
            _tKeysArray = new TKeys[_tKeysArray.Length + 1];

            for (int i = 0; i < _tempKeysArray.Length; i++)
            {
                _tKeysArray[i] = _tempKeysArray[i];
                _tValuesArray[i] = _tempValuesArray[i];
            }

            _tKeysArray[_tKeysArray.Length - 1] = key;
            _tValuesArray[_tValuesArray.Length - 1] = value;
        }

        public void toList()
        {
            for (int i = 0; i < _tKeysArray.Length; i++)
            {
                Console.WriteLine(_tKeysArray[i] + " : " + _tValuesArray[i] );
            }
        }
    }
}
