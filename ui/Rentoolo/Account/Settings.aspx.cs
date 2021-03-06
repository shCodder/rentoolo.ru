﻿using System;
using Rentoolo.Model;

namespace Rentoolo.Account
{
    public partial class Settings : BasicPage
    {
        public Memberships MembershipUserMembership;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.UpdateSession();

                MembershipUserMembership = DataHelper.GetUserMembership(User.UserId);

                Model.Referrals referal = DataHelper.GetReferral(User.UserId);

                if (referal != null)
                {
                    Users referrer = DataHelper.GetUser(referal.ReferrerUserId);

                    
                }

                TextBoxEmail.Text = MembershipUserMembership.Email;
                TextBoxCommunication.Text = User.Communication;
            }
        }
    }
}