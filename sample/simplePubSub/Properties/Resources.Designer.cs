﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rpcExample.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("simplePubSub.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aplicação encerrada com sucesso..
        /// </summary>
        public static string AplicacaoEncerrada {
            get {
                return ResourceManager.GetString("AplicacaoEncerrada", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Erro ao executar aplicação. Detalhes: ${0}.
        /// </summary>
        public static string ErroAoExecutarAplicacao {
            get {
                return ResourceManager.GetString("ErroAoExecutarAplicacao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It failed :(.
        /// </summary>
        public static string Falha {
            get {
                return ResourceManager.GetString("Falha", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Iniciando aplicação.
        /// </summary>
        public static string IniciandoAplicacao {
            get {
                return ResourceManager.GetString("IniciandoAplicacao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [.] Publicando mensagem para [testQueue123] ....
        /// </summary>
        public static string PublicandoMensagem {
            get {
                return ResourceManager.GetString("PublicandoMensagem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rodando aplicação. Pressione (enter) para encerrar..
        /// </summary>
        public static string RodandoAplicacao {
            get {
                return ResourceManager.GetString("RodandoAplicacao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - It works :-D !.
        /// </summary>
        public static string Sucesso {
            get {
                return ResourceManager.GetString("Sucesso", resourceCulture);
            }
        }
    }
}