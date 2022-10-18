

namespace VaultUserAccounts
{
    using System;
    using System.Collections.Generic;

    using Autodesk.Connectivity.WebServices;

    /// <summary>
    /// User information object.
    /// </summary>
    /// <remarks>
    /// Addam Boord - Ketiv - 2022
    /// Updated User class to match API changes for Vault 2022.
    /// </remarks>
    class UserInfo
    {

        public AuthTyp AuthType { get; private set; } = AuthTyp.Vault;

        public DateTime CreateDate { get; private set; }

        public long CreateUserId { get; private set; } 

        public string Email { get; private set; }

        public long Id { get; private set; }

        public bool IsAct { get; private set; }

        public bool IsSys { get; private set; }

        public string Name { get; private set; }

        public UserInfo()
        {
        }

        public UserInfo(User user)
        {
            AuthType = user.Auth;
            CreateDate = user.CreateDate;
            CreateUserId = user.CreateUserId;
            Email = user.Email;
            Id = user.Id;
            IsAct = user.IsAct;
            IsSys = user.IsSys;
            Name = user.Name;
        }

    }


    //class UserInfo
    //{

    //    private string _firstName = string.Empty;
    //    private string _lastName = string.Empty;
    //    private string _loginName = string.Empty;
    //    private string _password = string.Empty;
    //    private string _email = string.Empty;
    //    private List<string> _roles;
    //    private List<string> _groups;
    //    private List<string> _vaults;
    //    private bool _isAct = false;

    //    public UserInfo()
    //    {
    //    }

    //    public UserInfo(User user)
    //    {
    //        FirstName = user.FirstName;
    //        LastName = user.LastName;
    //        LoginName = user.Name;
    //        EMail = user.Email;
    //        Active = user.IsActive;
    //    }

    //    public bool Active
    //    {
    //        get { return _isAct; }
    //        set { _isAct = value; }
    //    }

    //    public string FirstName
    //    {
    //        get { return _firstName; }
    //        set { _firstName = value; }
    //    }

    //    public string LastName
    //    {
    //        get { return _lastName; }
    //        set { _lastName = value; }
    //    }

    //    public string LoginName
    //    {
    //        get { return _loginName; }
    //        set { _loginName = value; }
    //    }

    //    public string Password
    //    {
    //        get { return _password; }
    //        set { _password = value; }
    //    }

    //    public string EMail
    //    {
    //        get { return _email; }
    //        set { _email = value; }
    //    }

    //    public List<string> Groups
    //    {
    //        get
    //        {
    //            if (null == _groups)
    //            {
    //                _groups = new List<string>();
    //            }
    //            return _groups;
    //        }
    //    }

    //    public List<string> Roles
    //    {
    //        get
    //        {
    //            if (null == _roles)
    //            {
    //                _roles = new List<string>();
    //            }
    //            return _roles;
    //        }
    //    }

    //    public List<string> Vaults
    //    {
    //        get
    //        {
    //            if (null == _vaults)
    //            {
    //                _vaults = new List<string>();
    //            }
    //            return _vaults;
    //        }
    //    }

    //}
}
