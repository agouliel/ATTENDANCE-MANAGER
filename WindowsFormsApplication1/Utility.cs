using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WindowsFormsApplication1
{
    public class ThreadTask
    {
        private int m_actioninterval;
        private int m_pauseinterval;
        private Thread _athread;
        public delegate void Delegate_ThreadTask(Thread th);
        public event Delegate_ThreadTask OnThreadAction;
        public ThreadTask(int intervalseconds)
        {
            this.m_actioninterval = intervalseconds;
            _athread = new Thread(new ThreadStart(ThreadAction));
            _athread.IsBackground = true;



        }
        private void ThreadAction()
        {
            if (OnThreadAction != null)
            {
                while (true)
                {
                    OnThreadAction(this._athread);
                    Thread.Sleep(m_actioninterval * 1000);
                }
            }
        }
        private void Start()
        {

            this._athread.Start();
        }
        private void Stop()
        {
            this._athread.Suspend();
        }
        public Thread MainThread
        {
            get
            {
                return _athread;
            }
        }

    }
    
}
