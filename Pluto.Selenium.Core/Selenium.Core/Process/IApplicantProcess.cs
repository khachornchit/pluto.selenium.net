﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCore.Process
{
    public interface IApplicantProcess
    {
        bool InteressentMandatoryTest();
        bool InteressentMandatoryFill();
        bool ApplicantMandatoryTest();
        bool ApplicantMandatoryFill();
    }
}