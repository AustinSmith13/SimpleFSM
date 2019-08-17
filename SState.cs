using System.Collections.Generic;

namespace SimpleFsm {
    public abstract class SState {

        #region properties

        public IMachine Context {
            get {
                return this.context;
            }

            set {
                if (this.context == null) {
                    this.context = value;
                }
            }
        }

        public ITransitionGraph TransitionGraph {
            get {
                return this.transitionGraph;
            }

            set {
                if (this.transitionGraph == null) {
                    this.transitionGraph = value;
                }
            }
        }

        #endregion

        private IMachine context;
        private ITransitionGraph transitionGraph;

        public SState () { }

        /// <summary>
        /// Called when the state enters.
        /// </summary>
        public abstract void Enter ();

        /// <summary>
        /// Called when the state exits.
        /// </summary>
        public abstract void Exit ();

        /// <summary>
        /// Called when the state is active.
        /// </summary>
        public abstract void Execute ();

    }
}