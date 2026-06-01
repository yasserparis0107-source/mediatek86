-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 01 juin 2026 à 18:10
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `db_mediatek86_perso`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2025-01-03 00:00:00', '2025-01-05 00:00:00', 2),
(2, '2025-01-10 00:00:00', '2025-01-12 00:00:00', 1),
(3, '2025-02-01 00:00:00', '2025-02-03 00:00:00', 3),
(4, '2025-02-15 00:00:00', '2025-02-20 00:00:00', 4),
(5, '2025-03-02 00:00:00', '2025-03-04 00:00:00', 2),
(6, '2025-03-10 00:00:00', '2025-03-15 00:00:00', 5),
(7, '2025-03-18 00:00:00', '2025-03-20 00:00:00', 1),
(8, '2025-04-01 00:00:00', '2025-04-03 00:00:00', 3),
(9, '2025-04-10 00:00:00', '2025-04-12 00:00:00', 4),
(10, '2025-04-15 00:00:00', '2025-04-18 00:00:00', 2),
(1, '2025-05-01 00:00:00', '2025-05-03 00:00:00', 5),
(2, '2025-05-05 00:00:00', '2025-05-07 00:00:00', 2),
(3, '2025-05-10 00:00:00', '2025-05-12 00:00:00', 1),
(4, '2025-05-15 00:00:00', '2025-05-18 00:00:00', 3),
(5, '2025-06-01 00:00:00', '2025-06-05 00:00:00', 4),
(6, '2025-06-07 00:00:00', '2025-06-10 00:00:00', 2),
(7, '2025-06-12 00:00:00', '2025-06-15 00:00:00', 5),
(8, '2025-06-18 00:00:00', '2025-06-20 00:00:00', 1),
(9, '2025-07-01 00:00:00', '2025-07-03 00:00:00', 3),
(10, '2025-07-05 00:00:00', '2025-07-08 00:00:00', 4),
(1, '2025-07-10 00:00:00', '2025-07-12 00:00:00', 2),
(2, '2025-07-15 00:00:00', '2025-07-18 00:00:00', 5),
(3, '2025-08-01 00:00:00', '2025-08-05 00:00:00', 1),
(4, '2025-08-07 00:00:00', '2025-08-10 00:00:00', 3),
(5, '2025-08-12 00:00:00', '2025-08-15 00:00:00', 4),
(6, '2025-08-18 00:00:00', '2025-08-20 00:00:00', 2),
(7, '2025-09-01 00:00:00', '2025-09-03 00:00:00', 5),
(8, '2025-09-05 00:00:00', '2025-09-08 00:00:00', 1),
(9, '2025-09-10 00:00:00', '2025-09-12 00:00:00', 3),
(10, '2025-09-15 00:00:00', '2025-09-18 00:00:00', 4),
(1, '2025-10-01 00:00:00', '2025-10-03 00:00:00', 2),
(2, '2025-10-05 00:00:00', '2025-10-08 00:00:00', 5),
(3, '2025-10-10 00:00:00', '2025-10-12 00:00:00', 1),
(4, '2025-10-15 00:00:00', '2025-10-18 00:00:00', 3),
(5, '2025-11-01 00:00:00', '2025-11-03 00:00:00', 4),
(6, '2025-11-05 00:00:00', '2025-11-08 00:00:00', 2),
(7, '2025-11-10 00:00:00', '2025-11-12 00:00:00', 5),
(8, '2025-11-15 00:00:00', '2025-11-18 00:00:00', 1),
(9, '2025-12-01 00:00:00', '2025-12-03 00:00:00', 3),
(10, '2025-12-05 00:00:00', '2025-12-08 00:00:00', 4),
(3, '2026-01-10 00:00:00', '2026-01-12 00:00:00', 2),
(7, '2026-01-15 00:00:00', '2026-01-18 00:00:00', 4),
(1, '2026-02-01 00:00:00', '2026-02-03 00:00:00', 1),
(9, '2026-02-05 00:00:00', '2026-02-08 00:00:00', 3),
(5, '2026-02-10 00:00:00', '2026-02-14 00:00:00', 5),
(2, '2026-03-01 00:00:00', '2026-03-04 00:00:00', 2),
(8, '2026-03-06 00:00:00', '2026-03-09 00:00:00', 1),
(4, '2026-03-10 00:00:00', '2026-03-12 00:00:00', 3),
(6, '2026-03-15 00:00:00', '2026-03-18 00:00:00', 4),
(10, '2026-03-20 00:00:00', '2026-03-22 00:00:00', 2),
(3, '2026-06-01 23:08:04', '2026-06-03 23:08:04', 3),
(1, '2026-06-01 23:08:04', '2026-06-07 23:08:04', 5);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(3, 'maladie'),
(4, 'motif familial'),
(5, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Dupont', 'Jean', '0612345678', 'jean.dupont@email.com', 1),
(2, 'Martin', 'Claire', '0678451236', 'claire.martin@email.com', 2),
(3, 'Bernard', 'Lucas', '0622334455', 'lucas.bernard@email.com', 2),
(4, 'Petit', 'Sophie', '0699887766', 'sophie.petit@email.com', 3),
(5, 'Robert', 'Thomas', '0611223344', 'thomas.robert@email.com', 2),
(6, 'Richard', 'Emma', '0688776655', 'emma.richard@email.com', 3),
(7, 'Durand', 'Hugo', '0699999999', 'hugo.durand@email.com', 1),
(8, 'Moreau', 'Chloé', '0677123498', 'chloe.moreau@email.com', 3),
(9, 'Simon', 'Nathan', '0633557799', 'nathan.simon@email.com', 2),
(10, 'Laurent', 'Julie', '0644668899', 'julie.laurent@email.com', 2),
(12, 'fofo', 'qsfqsf', '0185695547', 'slsl@khkk.fr', 1),
(13, 'aaa', 'aaa', '0185624785', 'eeee@jjjj.gg', 3),
(14, 'tiki', 'taka', '0123456789', 'tikitaka@gmail.com', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');
-- ----------------------------------------------------------------------
-- mot de passe = 1234 (necessaire pour la connexion à l'application)
-- ----------------------------------------------------------------------
-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
