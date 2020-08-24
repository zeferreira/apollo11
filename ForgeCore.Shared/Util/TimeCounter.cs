using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ForgeCore.Shared
{
    public class TimeCounter
    {
        bool _timeIsOver;

        float _currentTime = 0f;
        public float CurrentTime { get => _currentTime; set => _currentTime = value; }

        float _timeLimitDuration = 2f;

        public TimeCounter()
        {
            this._timeLimitDuration = 2f;
        }

        public TimeCounter(float timeLimit)
        {
            this._timeLimitDuration = timeLimit;
        }

        public void Update()
        {
            int counter = 1;
            int limit = 50;

            _currentTime += (float)GameForgeEngine.Instance.MaxElapsedTime.TotalSeconds; //Time passed since last Update() 

            if (_currentTime >= _timeLimitDuration)
            {
                counter++;
                this._currentTime -= _timeLimitDuration; // "use up" the time
                                               //any actions to perform
                this._timeIsOver = true;
            }
            else
            {
                this._timeIsOver = false;
            }

            if (counter >= limit)
            {
                counter = 0;//Reset the counter;
                            //any actions to perform
            }
        }

        private bool TimeIsFinished()
        {
            return this._timeIsOver;
        }
    }
}