using System;

using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Internal.Parameters
{
    internal class ElGamalPrivateKeyParameters
		: ElGamalKeyParameters
    {
        private readonly BigInteger x;

		public ElGamalPrivateKeyParameters(
            BigInteger			x,
            DHParameters	parameters)
			: base(true, parameters)
        {
			if (x == null)
				throw new ArgumentNullException("x");

			this.x = x;
        }

		public BigInteger X
        {
            get { return x; }
        }

		public override bool Equals(
			object obj)
		{
			if (obj == this)
				return true;

			ElGamalPrivateKeyParameters other = obj as ElGamalPrivateKeyParameters;

			if (other == null)
				return false;

			return Equals(other);
		}

		protected bool Equals(
			ElGamalPrivateKeyParameters other)
		{
			return other.x.Equals(x) && base.Equals(other);
		}

		public override int GetHashCode()
		{
			return x.GetHashCode() ^ base.GetHashCode();
		}
    }
}
