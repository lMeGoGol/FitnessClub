using FitnessClub.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessClub.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
