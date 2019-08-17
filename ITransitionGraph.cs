using System;

namespace SimpleFsm {
    public interface ITransitionGraph {
        ITransition On (string action);
    }
}