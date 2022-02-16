using System;

namespace OOP_Course.Lesson4._4_1
{
    internal class Building
    {
        private static int _lastfreeId;
        private int _buildingid;
        private int _levels;
        private float _height;
        private int _flats;
        private const int FlatsByLevel = 4;
        private int _entrances;

        internal Building()
        {
            GenerateId();
        }
        private void GenerateId()
        {
            _buildingid = ++_lastfreeId;
        }

        private void CalculateHeight()
        {
            _height = _levels * 2.9f;
        }

        private int CalculateFlatsByEntrances()
        {
            return FlatsByLevel * _levels;
        }

        private void CalculateTotalFlats()
        {
            _flats = _entrances * CalculateFlatsByEntrances();
        }
    }
}
