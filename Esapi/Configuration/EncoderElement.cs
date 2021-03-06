﻿using System.Configuration;

namespace Owasp.Esapi.Configuration
{
    /// <summary>
    /// The EncoderElement Configuration Element.
    /// </summary>
    public class EncoderElement : ConfigurationElement
    {
        #region Type Property

        /// <summary>
        /// The XML name of the <see cref="Type"/> property.
        /// </summary>
        internal const string TypePropertyName = "type";

        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [ConfigurationProperty(TypePropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public string Type
        {
            get
            {
                return (string)base[TypePropertyName];
            }
            set
            {
                base[TypePropertyName] = value;
            }
        }

        #endregion

        #region Codecs Property

        /// <summary>
        /// The XML name of the <see cref="Codecs"/> property.
        /// </summary>
        internal const string CodecsPropertyName = "codecs";

        /// <summary>
        /// Gets or sets the Codecs.
        /// </summary>
        [ConfigurationProperty(CodecsPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public CodecCollection Codecs
        {
            get
            {
                return (CodecCollection)base[CodecsPropertyName];
            }
            set
            {
                base[CodecsPropertyName] = value;
            }
        }

        #endregion

    }
}
