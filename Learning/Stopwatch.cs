using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Stopwatch
    {
        private double _duration;
        private DateTime _start;
        private DateTime _end;
        private bool _started;
        private bool _stopped;

        public double Duration { 
            get {
                if (!this._started && !this._stopped)
                    return 0;
                return Convert.ToDouble((this._end - this._start).TotalSeconds.ToString());
            }
                 }

        public Stopwatch()
        {
            this._started = false;
            this._stopped = false;
        }
        public void Start()
        {
            if (this._started)
                throw new InvalidOperationException("StopWatch already started");
            this._started = true;
            this._stopped = false;
            

            this._start = DateTime.Now;
        }

        public void Stop()
        {
            if (this._started == false && this._stopped == false)
                throw new InvalidOperationException("StopWatch did not even start");
            if (this._started == false && this._stopped == true)
                throw new InvalidOperationException("StopWatch already stopped");
            this._stopped = true;
            this._started = false;
            

            this._end = DateTime.Now;
        }


    }
}
