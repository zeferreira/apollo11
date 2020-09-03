using System;
using System.Collections;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class GameConfig
    {
        private static volatile GameConfig _instance;
        private static readonly object _padLock = new object();

        private int _mobileWidth = 800;
        private int _mobileHeight = 480;

        private int _desktopWidth = 1280;
        private int _desktopHeight = 720;



        public static GameConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padLock)
                    {
                        if (_instance == null)
                            _instance = new GameConfig();
                    }
                }

                return _instance;
            }
        }
        
        private GameConfig()
        {

            _playerHandSize = (int)(0.8 * this._wScreenSize);


#if ANDROID
            this._hScreenSize = _mobileHeight;
            this._wScreenSize = _mobileWidth;
#elif LINUX
            this._hScreenSize = _desktopHeight;
            this._wScreenSize = _desktopWidth;
#endif
        }

        private bool _isFullScreen;

        public bool IsFullScreen
        {
            get
            {

#if ANDROID
                _isFullScreen = true;
#elif LINUX
                _isFullScreen = false;
#endif

                lock (_padLock)
                {
                    return _isFullScreen;
                }
            }
        }

        private int _playerHandSize;

        public int PlayerHandSize
        {
            get
            {
                lock (_padLock)
                {
                    return _playerHandSize;
                }
            }
        }

        private int _wScreenSize;

        public int WScreenSize 
        {
            get
            {
                lock (_padLock)
                {
                    return _wScreenSize;
                }
            }
        }
        
        private int _hScreenSize;

        public int HScreenSize
        {
            get
            {
                lock (_padLock)
                {
                    return _hScreenSize;
                }
            }
        }

        private Dictionary<string, object> _properties;
        public Dictionary<string, object> Properties { get => _properties; set => _properties = value; }

    }
}