using JetBrains.Annotations;
using SolastaModApi.Infrastructure;
using System;

namespace SolastaTesting.SolastaModApi
{
    public class SetResetToken : Disposable
    {
        private Action _reset;

        public SetResetToken([NotNull] Action set, [NotNull] Action reset)
        {
            Preconditions.IsNotNull(set, nameof(set));
            Preconditions.IsNotNull(reset, nameof(reset));

            _reset = reset;

            set();
        }

        protected override void Dispose(bool disposing)
        {
            if (_reset != null)
            {
                _reset();
                _reset = null;
            }
        }
    }
}
