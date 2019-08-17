using System;

namespace SimpleFsm {
    public class STransition : ITransition {
        private IMachine context;
        private ITransitionGraph parent;
        private Action action;
        private SState next;

        public STransition (IMachine context, ITransitionGraph parent) {
            this.context = context;
            this.parent = parent;
        }

        public ITransitionGraph GoTo<T> () where T : SState {
            this.next = this.context.Create<T> ();
            return this.parent;
        }

        public ITransitionGraph Execute (Action action) {
            this.action = action;
            return this.parent;
        }

        public SState GetNext () {
            return this.next;
        }

        public Action GetAction () {
            return this.action;
        }
    }
}