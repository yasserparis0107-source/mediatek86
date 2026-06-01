using mediatek86.dal;
using mediatek86.model;
using System;

namespace mediatek86.controller
{
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        ///private readonly DeveloppeurAccess developpeurAccess;

        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            ///developpeurAccess = new DeveloppeurAccess();
            access = Access.GetInstance();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return access.ControleAuthentification(responsable);
        }

    }
}
