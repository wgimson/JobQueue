using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobQueueApp
{
    public class JobProcessing
    {
        private string[] _jobs;
        private int _resizeFactor;
        private int _startPos;
        private int _endPos;

        public JobProcessing(int resizeFactor)
        {
            _resizeFactor = resizeFactor;
            _startPos = 0;
            _endPos = 0;
            _jobs = new string[16];
        }

        public JobProcessing(int resizeFactor, int initLength)
        {
            _resizeFactor = resizeFactor;
            _startPos = 0;
            _endPos = 0;
            _jobs = new string[initLength];
        }

        public void AddJob(string jobName)
        {
            if (IsFull())
            {
                IncreaseArrySize();
                _endPos = (_jobs.Length / _resizeFactor);
            }
            _jobs[_endPos] = jobName;
            IncrementEndPos();
        }

        public string GetNextJob()
        {
            string nextJob = _jobs[_startPos];
            _jobs[_startPos] = null;
            IncrementStartPos();
            return nextJob;
        }

        public string Peek()
        {
            return _jobs[_startPos];
        }

        private int IncrementStartPos()
        {
            _startPos = (_startPos + 1) % _jobs.Length;
            return _startPos;
        }

        private int IncrementEndPos()
        {
            _endPos = (_endPos + 1) % _jobs.Length;
            return _endPos;
        }

        private bool IsFull()
        {
            return (_startPos == _endPos && _jobs[_endPos + 1] != null) ? true : false;
        }

        private bool IsEmpty()
        {
            return (_startPos == _endPos && _jobs[_endPos + 1] == null) ? true : false;
        }

        private void IncreaseArrySize()
        {
            Array.Resize<string>(ref _jobs, (_jobs.Length * _resizeFactor));
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (IsEmpty())
                str.Append("The Job Queue is Empty\n");
            else if (IsFull())
            {
                for (var i = 0; i < _jobs.Length; i++)
                {
                    str.Append("Value at Postion: " + i + " is: " + _jobs[i] + " Queue length is: " + _jobs.Length + "\n");
                }
            }
            else
            {
                for (var i = _startPos; i != _endPos; )
                {
                    str.Append("Value at Postion: " + i + " is: " + _jobs[i] + " Queue length is: " + _jobs.Length + "\n");
                    i = (++i % _jobs.Length);
                }
            }
            return str.ToString();
        }
    }
}