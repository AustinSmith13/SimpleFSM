using System;

namespace SimpleFsm {
    public interface ITransition {
        ITransitionGraph GoTo<T> () where T : SState;
        ITransitionGraph Execute (Action action);
        SState GetState ();
        Action GetAction ();
    }
}