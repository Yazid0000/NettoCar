# 🚗 NettoCar — Système de Gestion de Lavage Auto

NettoCar est une application de bureau développée en **Visual Basic 2010** avec une base de données **Microsoft Access**, conçue pour gérer les opérations quotidiennes d'un centre de lavage automobile.

---

## ✨ Fonctionnalités

### 🔐 Authentification & Sécurité
- Connexion par login/mot de passe pour chaque employé
- Session globale — toutes les actions sont liées à l'employé connecté
- Affichage de l'employé connecté dans la barre de navigation

### 🧾 Gestion des Lavages
- Démarrage d'un nouveau lavage (client, service, heure de début)
- Suivi des lavages en cours
- Clôture de lavage avec heure de fin enregistrée

### 📦 Gestion du Stock
- Entrées de stock avec lien fournisseur
- Sorties de stock avec motif
- Historique complet des mouvements
- Alertes de stock bas

### 📋 Journal de Prévention des Pertes
- Traçabilité complète de toutes les actions
- Événements enregistrés : connexions, lavages, mouvements de stock, suppressions
- Filtres par date et par type d'événement
- Impression en mode paysage

### 👥 Gestion des Entités
- Agences, Employés, Clients
- Services, Produits, Fournisseurs

### 📊 Statistiques & Tableaux de Bord
- KPIs en temps réel (agences, clients, employés, stock)
- Activité récente des employés

---

## 📸 Captures d'écran

### Tableau de bord
<!-- Ajouter screenshot tableau de bord ici -->

### Login
<!-- Ajouter screenshot login ici -->

### Gestion des Lavages
<!-- Ajouter screenshot lavages ici -->

### Journal de Prévention des Pertes
<!-- Ajouter screenshot journal ici -->

### Gestion du Stock
<!-- Ajouter screenshot stock ici -->

---

## 🛠️ Technologies utilisées

| Technologie | Version |
|---|---|
| Visual Basic .NET | 2010 Express |
| Microsoft Access | 2002-2003 (.mdb) |
| .NET Framework | 4.0 |

---

## 🚀 Installation

1. Cloner le dépôt :
```bash
git clone https://github.com/[ton-username]/NettoCar.git
```

2. Ouvrir le fichier `NettoCar2010.sln` avec **Visual Basic 2010 Express**

3. Vérifier que le fichier `syspaie.mdb` est présent dans le dossier `bin/Debug`

4. Compiler et lancer le projet

---

## 🔑 Connexion par défaut

| Login | Mot de passe | Rôle |
|---|---|---|
| admin | admin123 | Administrateur |

---

## 📁 Structure du projet

```
NettoCar2010/
├── frmMain.vb              # Tableau de bord principal
├── frmLogin.vb             # Authentification
├── frmLavages.vb           # Gestion des lavages
├── frmJournal.vb           # Journal de prévention des pertes
├── frmStock.vb             # Mouvements de stock
├── frmDialogsAutres.vb     # Formulaires de saisie
├── Module1.vb              # DBConnection + Session + Journal
├── StyleHelper.vb          # Styles et impression
└── bin/Debug/
    └── syspaie.mdb         # Base de données Access
```

---

## 👨‍💻 Auteur

**Yazid Bennouna**  
Étudiant en informatique  

---

## 📄 Licence

Ce projet est développé dans le cadre d'un projet académique.
