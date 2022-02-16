using System;

namespace OOP_Course.Lesson4._4_1
{
    internal class Building
    {
        private static int _lastfreeId;
        private int _buildingid;
        private readonly int _levels;
        private float _height;
        private int _flats;
        private const int FlatsByLevel = 4;
        private readonly int _entrances;

        internal Building(int levels, int entrances)
        {
            GenerateId();
            _levels = levels;
            _entrances = entrances;
            CalculateHeight();
            CalculateTotalFlats();
        }

        internal void PrintBuildingDetails()
        {
            Console.WriteLine("ID: {0}",_buildingid);
            Console.WriteLine("Levels: {0}", _levels);
            Console.WriteLine("Height: {0}m", _height);
            Console.WriteLine("Flats: {0}", _flats);
            Console.WriteLine("Entrances: {0}", _entrances);
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
