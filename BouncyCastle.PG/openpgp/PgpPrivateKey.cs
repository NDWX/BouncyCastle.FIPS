
using Org.BouncyCastle.Bcpg;

namespace Org.BouncyCastle.OpenPgp
{
	/// <remarks>General class to contain a private key for use with other OpenPGP objects.</remarks>
    public class PgpPrivateKey
    {
        private readonly long keyID;
        private readonly PublicKeyPacket publicKeyPacket;
        private readonly IBcpgKey privateKey;

        /// <summary>
		/// Create a PgpPrivateKey from a keyID, the associated public data packet, and a regular private key.
		/// </summary>
		/// <param name="keyID">ID of the corresponding public key.</param>
        /// <param name="publicKeyPacket">the public key data packet to be associated with this private key.</param>
        /// <param name="privateKey">the private key packet to be associated with this private key.</param>
        public PgpPrivateKey(
            long                    keyID,
            PublicKeyPacket         publicKeyPacket,
            IBcpgKey                privateKey)
        {
            this.keyID = keyID;
            this.publicKeyPacket = publicKeyPacket;
            this.privateKey = privateKey;
        }

        /// <summary>The keyId associated with the contained private key.</summary>
        public long KeyId
        {
			get { return keyID; }
        }

        /// <summary>The public key packet associated with this private key, if available.</summary>
        public PublicKeyPacket PublicKeyPacket
        {
            get { return publicKeyPacket; }
        }

        /// <summary>The contained private key.</summary>
        public IBcpgKey Key
        {
			get { return privateKey; }
        }
    }
}
