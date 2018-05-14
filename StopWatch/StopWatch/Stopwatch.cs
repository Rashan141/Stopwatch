using System;
using System.Collections.Generic;

namespace StopWatch
{
        class Stopwatch {
            private string _name;
            private DateTime _start;
            private bool _onStart = false;
            private DateTime _end;
            private List<TimeSpan> _timeSpans;


        public Stopwatch(string name)
        {
            _name = name;
            _timeSpans = new List<TimeSpan>();
        }
            public void Start() {
                if (_onStart == false)
                {
                    Console.WriteLine("Starting clock {0}", _name);
                    _start = DateTime.Now;
                        _onStart = true;
                }
                else
                {
                    Console.WriteLine("Must stop timer to start again.");
                }
            }

            public void Stop() {
            Console.WriteLine("Ending clock {0}", _name);
                _end = DateTime.Today;
                _timeSpans.Add(_start - _end);
                _onStart = false;
            Console.WriteLine("Fully endwed.");
            }

            public void GetTimeSpans() {
                foreach (var time in _timeSpans)
                {
                    Console.WriteLine("+-------------------+");
                    Console.WriteLine(time.Seconds);
                    Console.WriteLine("+-------------------+");
                }
            }

        }
}
