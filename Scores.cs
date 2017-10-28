using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Scores
    {
        private int _teamNumber;
        private string _teamName;
        private int _p;
        private int _w;
        private int _l;
        private int _d;
        private int _f;
        private string _hyphen;
        private int _a;
        private int _points;
        private double _difference;

        public Scores(string teamName, int p, int w, int l, int d, int f, string hyphen, int a, int points)
        {
            var teamNoName = teamName.Split('.');
            TeamNumber = int.Parse(teamNoName[0]);
            TeamName = teamNoName[1];
            P = p;
            W = w;
            L = l;
            D = d;
            F = f;
            Hyphen = hyphen;
            A = a;
            Points = points;
            Difference = f - a;
        }
        #region Properties
        public int TeamNumber
        {
            get { return _teamNumber; }
            set { _teamNumber = value; }
        }

        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        public int P
        {
            get { return _p; }
            set { _p = value; }
        }

        public int W
        {
            get { return _w; }
            set { _w = value; }
        }

        public int L
        {
            get { return _l; }
            set { _l = value; }
        }

        public int D
        {
            get { return _d; }
            set { _d = value; }
        }

        public int F
        {
            get { return _f; }
            set { _f = value; }
        }

        public string Hyphen
        {
            get { return _hyphen; }
            set { _hyphen = value; }
        }

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public double Difference
        {
            get { return _difference; }
            set { _difference = value; }
        }
        #endregion



    }
}
