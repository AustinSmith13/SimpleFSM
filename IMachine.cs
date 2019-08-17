using System;

namespace SimpleFsm {
    public delegate T FactoryFunc<T> ();
    public interface IMachine {
        SState GetCurren ();
        SState GetInitial ();
        void Execute ();
        void Reset ();
        void Process (string action);
        ITransitionGraph In<T> () where T : SState, new ();
        void AddFactoryFor<T> (FactoryFunc<T> method) where T : SState;
        T Get<T> () where T : SState, new ();
    }
}