﻿using Implem.Pleasanter.Libraries.Converts;
using Implem.Pleasanter.Libraries.DataTypes;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
using System.Collections.Generic;
namespace Implem.Pleasanter.Models
{
    public class ResultSubset
    {
        public long SiteId;
        public string SiteId_LabelText;
        public Time UpdatedTime;
        public string UpdatedTime_LabelText;
        public long ResultId;
        public string ResultId_LabelText;
        public int Ver;
        public string Ver_LabelText;
        public Title Title;
        public string Title_LabelText;
        public string Body;
        public string Body_LabelText;
        public TitleBody TitleBody;
        public string TitleBody_LabelText;
        public Status Status;
        public string Status_LabelText;
        public User Manager;
        public string Manager_LabelText;
        public User Owner;
        public string Owner_LabelText;
        public string ClassA;
        public string ClassA_LabelText;
        public string ClassB;
        public string ClassB_LabelText;
        public string ClassC;
        public string ClassC_LabelText;
        public string ClassD;
        public string ClassD_LabelText;
        public string ClassE;
        public string ClassE_LabelText;
        public string ClassF;
        public string ClassF_LabelText;
        public string ClassG;
        public string ClassG_LabelText;
        public string ClassH;
        public string ClassH_LabelText;
        public string ClassI;
        public string ClassI_LabelText;
        public string ClassJ;
        public string ClassJ_LabelText;
        public string ClassK;
        public string ClassK_LabelText;
        public string ClassL;
        public string ClassL_LabelText;
        public string ClassM;
        public string ClassM_LabelText;
        public string ClassN;
        public string ClassN_LabelText;
        public string ClassO;
        public string ClassO_LabelText;
        public string ClassP;
        public string ClassP_LabelText;
        public string ClassQ;
        public string ClassQ_LabelText;
        public string ClassR;
        public string ClassR_LabelText;
        public string ClassS;
        public string ClassS_LabelText;
        public string ClassT;
        public string ClassT_LabelText;
        public string ClassU;
        public string ClassU_LabelText;
        public string ClassV;
        public string ClassV_LabelText;
        public string ClassW;
        public string ClassW_LabelText;
        public string ClassX;
        public string ClassX_LabelText;
        public string ClassY;
        public string ClassY_LabelText;
        public string ClassZ;
        public string ClassZ_LabelText;
        public decimal NumA;
        public string NumA_LabelText;
        public decimal NumB;
        public string NumB_LabelText;
        public decimal NumC;
        public string NumC_LabelText;
        public decimal NumD;
        public string NumD_LabelText;
        public decimal NumE;
        public string NumE_LabelText;
        public decimal NumF;
        public string NumF_LabelText;
        public decimal NumG;
        public string NumG_LabelText;
        public decimal NumH;
        public string NumH_LabelText;
        public decimal NumI;
        public string NumI_LabelText;
        public decimal NumJ;
        public string NumJ_LabelText;
        public decimal NumK;
        public string NumK_LabelText;
        public decimal NumL;
        public string NumL_LabelText;
        public decimal NumM;
        public string NumM_LabelText;
        public decimal NumN;
        public string NumN_LabelText;
        public decimal NumO;
        public string NumO_LabelText;
        public decimal NumP;
        public string NumP_LabelText;
        public decimal NumQ;
        public string NumQ_LabelText;
        public decimal NumR;
        public string NumR_LabelText;
        public decimal NumS;
        public string NumS_LabelText;
        public decimal NumT;
        public string NumT_LabelText;
        public decimal NumU;
        public string NumU_LabelText;
        public decimal NumV;
        public string NumV_LabelText;
        public decimal NumW;
        public string NumW_LabelText;
        public decimal NumX;
        public string NumX_LabelText;
        public decimal NumY;
        public string NumY_LabelText;
        public decimal NumZ;
        public string NumZ_LabelText;
        public DateTime DateA;
        public string DateA_LabelText;
        public DateTime DateB;
        public string DateB_LabelText;
        public DateTime DateC;
        public string DateC_LabelText;
        public DateTime DateD;
        public string DateD_LabelText;
        public DateTime DateE;
        public string DateE_LabelText;
        public DateTime DateF;
        public string DateF_LabelText;
        public DateTime DateG;
        public string DateG_LabelText;
        public DateTime DateH;
        public string DateH_LabelText;
        public DateTime DateI;
        public string DateI_LabelText;
        public DateTime DateJ;
        public string DateJ_LabelText;
        public DateTime DateK;
        public string DateK_LabelText;
        public DateTime DateL;
        public string DateL_LabelText;
        public DateTime DateM;
        public string DateM_LabelText;
        public DateTime DateN;
        public string DateN_LabelText;
        public DateTime DateO;
        public string DateO_LabelText;
        public DateTime DateP;
        public string DateP_LabelText;
        public DateTime DateQ;
        public string DateQ_LabelText;
        public DateTime DateR;
        public string DateR_LabelText;
        public DateTime DateS;
        public string DateS_LabelText;
        public DateTime DateT;
        public string DateT_LabelText;
        public DateTime DateU;
        public string DateU_LabelText;
        public DateTime DateV;
        public string DateV_LabelText;
        public DateTime DateW;
        public string DateW_LabelText;
        public DateTime DateX;
        public string DateX_LabelText;
        public DateTime DateY;
        public string DateY_LabelText;
        public DateTime DateZ;
        public string DateZ_LabelText;
        public string DescriptionA;
        public string DescriptionA_LabelText;
        public string DescriptionB;
        public string DescriptionB_LabelText;
        public string DescriptionC;
        public string DescriptionC_LabelText;
        public string DescriptionD;
        public string DescriptionD_LabelText;
        public string DescriptionE;
        public string DescriptionE_LabelText;
        public string DescriptionF;
        public string DescriptionF_LabelText;
        public string DescriptionG;
        public string DescriptionG_LabelText;
        public string DescriptionH;
        public string DescriptionH_LabelText;
        public string DescriptionI;
        public string DescriptionI_LabelText;
        public string DescriptionJ;
        public string DescriptionJ_LabelText;
        public string DescriptionK;
        public string DescriptionK_LabelText;
        public string DescriptionL;
        public string DescriptionL_LabelText;
        public string DescriptionM;
        public string DescriptionM_LabelText;
        public string DescriptionN;
        public string DescriptionN_LabelText;
        public string DescriptionO;
        public string DescriptionO_LabelText;
        public string DescriptionP;
        public string DescriptionP_LabelText;
        public string DescriptionQ;
        public string DescriptionQ_LabelText;
        public string DescriptionR;
        public string DescriptionR_LabelText;
        public string DescriptionS;
        public string DescriptionS_LabelText;
        public string DescriptionT;
        public string DescriptionT_LabelText;
        public string DescriptionU;
        public string DescriptionU_LabelText;
        public string DescriptionV;
        public string DescriptionV_LabelText;
        public string DescriptionW;
        public string DescriptionW_LabelText;
        public string DescriptionX;
        public string DescriptionX_LabelText;
        public string DescriptionY;
        public string DescriptionY_LabelText;
        public string DescriptionZ;
        public string DescriptionZ_LabelText;
        public bool CheckA;
        public string CheckA_LabelText;
        public bool CheckB;
        public string CheckB_LabelText;
        public bool CheckC;
        public string CheckC_LabelText;
        public bool CheckD;
        public string CheckD_LabelText;
        public bool CheckE;
        public string CheckE_LabelText;
        public bool CheckF;
        public string CheckF_LabelText;
        public bool CheckG;
        public string CheckG_LabelText;
        public bool CheckH;
        public string CheckH_LabelText;
        public bool CheckI;
        public string CheckI_LabelText;
        public bool CheckJ;
        public string CheckJ_LabelText;
        public bool CheckK;
        public string CheckK_LabelText;
        public bool CheckL;
        public string CheckL_LabelText;
        public bool CheckM;
        public string CheckM_LabelText;
        public bool CheckN;
        public string CheckN_LabelText;
        public bool CheckO;
        public string CheckO_LabelText;
        public bool CheckP;
        public string CheckP_LabelText;
        public bool CheckQ;
        public string CheckQ_LabelText;
        public bool CheckR;
        public string CheckR_LabelText;
        public bool CheckS;
        public string CheckS_LabelText;
        public bool CheckT;
        public string CheckT_LabelText;
        public bool CheckU;
        public string CheckU_LabelText;
        public bool CheckV;
        public string CheckV_LabelText;
        public bool CheckW;
        public string CheckW_LabelText;
        public bool CheckX;
        public string CheckX_LabelText;
        public bool CheckY;
        public string CheckY_LabelText;
        public bool CheckZ;
        public string CheckZ_LabelText;
        public Comments Comments;
        public string Comments_LabelText;
        public User Creator;
        public string Creator_LabelText;
        public User Updator;
        public string Updator_LabelText;
        public Time CreatedTime;
        public string CreatedTime_LabelText;
        public bool VerUp;
        public string VerUp_LabelText;
        public string Timestamp;
        public string Timestamp_LabelText;

        public ResultSubset()
        {
        }

        public ResultSubset(ResultModel resultModel, SiteSettings siteSettings)
        {
            SiteId = resultModel.SiteId;
            SiteId_LabelText = siteSettings.EditorColumn("SiteId")?.LabelText;
            UpdatedTime = resultModel.UpdatedTime;
            UpdatedTime_LabelText = siteSettings.EditorColumn("UpdatedTime")?.LabelText;
            ResultId = resultModel.ResultId;
            ResultId_LabelText = siteSettings.EditorColumn("ResultId")?.LabelText;
            Ver = resultModel.Ver;
            Ver_LabelText = siteSettings.EditorColumn("Ver")?.LabelText;
            Title = resultModel.Title;
            Title_LabelText = siteSettings.EditorColumn("Title")?.LabelText;
            Body = resultModel.Body;
            Body_LabelText = siteSettings.EditorColumn("Body")?.LabelText;
            TitleBody = resultModel.TitleBody;
            TitleBody_LabelText = siteSettings.EditorColumn("TitleBody")?.LabelText;
            Status = resultModel.Status;
            Status_LabelText = siteSettings.EditorColumn("Status")?.LabelText;
            Manager = resultModel.Manager;
            Manager_LabelText = siteSettings.EditorColumn("Manager")?.LabelText;
            Owner = resultModel.Owner;
            Owner_LabelText = siteSettings.EditorColumn("Owner")?.LabelText;
            ClassA = resultModel.ClassA;
            ClassA_LabelText = siteSettings.EditorColumn("ClassA")?.LabelText;
            ClassB = resultModel.ClassB;
            ClassB_LabelText = siteSettings.EditorColumn("ClassB")?.LabelText;
            ClassC = resultModel.ClassC;
            ClassC_LabelText = siteSettings.EditorColumn("ClassC")?.LabelText;
            ClassD = resultModel.ClassD;
            ClassD_LabelText = siteSettings.EditorColumn("ClassD")?.LabelText;
            ClassE = resultModel.ClassE;
            ClassE_LabelText = siteSettings.EditorColumn("ClassE")?.LabelText;
            ClassF = resultModel.ClassF;
            ClassF_LabelText = siteSettings.EditorColumn("ClassF")?.LabelText;
            ClassG = resultModel.ClassG;
            ClassG_LabelText = siteSettings.EditorColumn("ClassG")?.LabelText;
            ClassH = resultModel.ClassH;
            ClassH_LabelText = siteSettings.EditorColumn("ClassH")?.LabelText;
            ClassI = resultModel.ClassI;
            ClassI_LabelText = siteSettings.EditorColumn("ClassI")?.LabelText;
            ClassJ = resultModel.ClassJ;
            ClassJ_LabelText = siteSettings.EditorColumn("ClassJ")?.LabelText;
            ClassK = resultModel.ClassK;
            ClassK_LabelText = siteSettings.EditorColumn("ClassK")?.LabelText;
            ClassL = resultModel.ClassL;
            ClassL_LabelText = siteSettings.EditorColumn("ClassL")?.LabelText;
            ClassM = resultModel.ClassM;
            ClassM_LabelText = siteSettings.EditorColumn("ClassM")?.LabelText;
            ClassN = resultModel.ClassN;
            ClassN_LabelText = siteSettings.EditorColumn("ClassN")?.LabelText;
            ClassO = resultModel.ClassO;
            ClassO_LabelText = siteSettings.EditorColumn("ClassO")?.LabelText;
            ClassP = resultModel.ClassP;
            ClassP_LabelText = siteSettings.EditorColumn("ClassP")?.LabelText;
            ClassQ = resultModel.ClassQ;
            ClassQ_LabelText = siteSettings.EditorColumn("ClassQ")?.LabelText;
            ClassR = resultModel.ClassR;
            ClassR_LabelText = siteSettings.EditorColumn("ClassR")?.LabelText;
            ClassS = resultModel.ClassS;
            ClassS_LabelText = siteSettings.EditorColumn("ClassS")?.LabelText;
            ClassT = resultModel.ClassT;
            ClassT_LabelText = siteSettings.EditorColumn("ClassT")?.LabelText;
            ClassU = resultModel.ClassU;
            ClassU_LabelText = siteSettings.EditorColumn("ClassU")?.LabelText;
            ClassV = resultModel.ClassV;
            ClassV_LabelText = siteSettings.EditorColumn("ClassV")?.LabelText;
            ClassW = resultModel.ClassW;
            ClassW_LabelText = siteSettings.EditorColumn("ClassW")?.LabelText;
            ClassX = resultModel.ClassX;
            ClassX_LabelText = siteSettings.EditorColumn("ClassX")?.LabelText;
            ClassY = resultModel.ClassY;
            ClassY_LabelText = siteSettings.EditorColumn("ClassY")?.LabelText;
            ClassZ = resultModel.ClassZ;
            ClassZ_LabelText = siteSettings.EditorColumn("ClassZ")?.LabelText;
            NumA = resultModel.NumA;
            NumA_LabelText = siteSettings.EditorColumn("NumA")?.LabelText;
            NumB = resultModel.NumB;
            NumB_LabelText = siteSettings.EditorColumn("NumB")?.LabelText;
            NumC = resultModel.NumC;
            NumC_LabelText = siteSettings.EditorColumn("NumC")?.LabelText;
            NumD = resultModel.NumD;
            NumD_LabelText = siteSettings.EditorColumn("NumD")?.LabelText;
            NumE = resultModel.NumE;
            NumE_LabelText = siteSettings.EditorColumn("NumE")?.LabelText;
            NumF = resultModel.NumF;
            NumF_LabelText = siteSettings.EditorColumn("NumF")?.LabelText;
            NumG = resultModel.NumG;
            NumG_LabelText = siteSettings.EditorColumn("NumG")?.LabelText;
            NumH = resultModel.NumH;
            NumH_LabelText = siteSettings.EditorColumn("NumH")?.LabelText;
            NumI = resultModel.NumI;
            NumI_LabelText = siteSettings.EditorColumn("NumI")?.LabelText;
            NumJ = resultModel.NumJ;
            NumJ_LabelText = siteSettings.EditorColumn("NumJ")?.LabelText;
            NumK = resultModel.NumK;
            NumK_LabelText = siteSettings.EditorColumn("NumK")?.LabelText;
            NumL = resultModel.NumL;
            NumL_LabelText = siteSettings.EditorColumn("NumL")?.LabelText;
            NumM = resultModel.NumM;
            NumM_LabelText = siteSettings.EditorColumn("NumM")?.LabelText;
            NumN = resultModel.NumN;
            NumN_LabelText = siteSettings.EditorColumn("NumN")?.LabelText;
            NumO = resultModel.NumO;
            NumO_LabelText = siteSettings.EditorColumn("NumO")?.LabelText;
            NumP = resultModel.NumP;
            NumP_LabelText = siteSettings.EditorColumn("NumP")?.LabelText;
            NumQ = resultModel.NumQ;
            NumQ_LabelText = siteSettings.EditorColumn("NumQ")?.LabelText;
            NumR = resultModel.NumR;
            NumR_LabelText = siteSettings.EditorColumn("NumR")?.LabelText;
            NumS = resultModel.NumS;
            NumS_LabelText = siteSettings.EditorColumn("NumS")?.LabelText;
            NumT = resultModel.NumT;
            NumT_LabelText = siteSettings.EditorColumn("NumT")?.LabelText;
            NumU = resultModel.NumU;
            NumU_LabelText = siteSettings.EditorColumn("NumU")?.LabelText;
            NumV = resultModel.NumV;
            NumV_LabelText = siteSettings.EditorColumn("NumV")?.LabelText;
            NumW = resultModel.NumW;
            NumW_LabelText = siteSettings.EditorColumn("NumW")?.LabelText;
            NumX = resultModel.NumX;
            NumX_LabelText = siteSettings.EditorColumn("NumX")?.LabelText;
            NumY = resultModel.NumY;
            NumY_LabelText = siteSettings.EditorColumn("NumY")?.LabelText;
            NumZ = resultModel.NumZ;
            NumZ_LabelText = siteSettings.EditorColumn("NumZ")?.LabelText;
            DateA = resultModel.DateA;
            DateA_LabelText = siteSettings.EditorColumn("DateA")?.LabelText;
            DateB = resultModel.DateB;
            DateB_LabelText = siteSettings.EditorColumn("DateB")?.LabelText;
            DateC = resultModel.DateC;
            DateC_LabelText = siteSettings.EditorColumn("DateC")?.LabelText;
            DateD = resultModel.DateD;
            DateD_LabelText = siteSettings.EditorColumn("DateD")?.LabelText;
            DateE = resultModel.DateE;
            DateE_LabelText = siteSettings.EditorColumn("DateE")?.LabelText;
            DateF = resultModel.DateF;
            DateF_LabelText = siteSettings.EditorColumn("DateF")?.LabelText;
            DateG = resultModel.DateG;
            DateG_LabelText = siteSettings.EditorColumn("DateG")?.LabelText;
            DateH = resultModel.DateH;
            DateH_LabelText = siteSettings.EditorColumn("DateH")?.LabelText;
            DateI = resultModel.DateI;
            DateI_LabelText = siteSettings.EditorColumn("DateI")?.LabelText;
            DateJ = resultModel.DateJ;
            DateJ_LabelText = siteSettings.EditorColumn("DateJ")?.LabelText;
            DateK = resultModel.DateK;
            DateK_LabelText = siteSettings.EditorColumn("DateK")?.LabelText;
            DateL = resultModel.DateL;
            DateL_LabelText = siteSettings.EditorColumn("DateL")?.LabelText;
            DateM = resultModel.DateM;
            DateM_LabelText = siteSettings.EditorColumn("DateM")?.LabelText;
            DateN = resultModel.DateN;
            DateN_LabelText = siteSettings.EditorColumn("DateN")?.LabelText;
            DateO = resultModel.DateO;
            DateO_LabelText = siteSettings.EditorColumn("DateO")?.LabelText;
            DateP = resultModel.DateP;
            DateP_LabelText = siteSettings.EditorColumn("DateP")?.LabelText;
            DateQ = resultModel.DateQ;
            DateQ_LabelText = siteSettings.EditorColumn("DateQ")?.LabelText;
            DateR = resultModel.DateR;
            DateR_LabelText = siteSettings.EditorColumn("DateR")?.LabelText;
            DateS = resultModel.DateS;
            DateS_LabelText = siteSettings.EditorColumn("DateS")?.LabelText;
            DateT = resultModel.DateT;
            DateT_LabelText = siteSettings.EditorColumn("DateT")?.LabelText;
            DateU = resultModel.DateU;
            DateU_LabelText = siteSettings.EditorColumn("DateU")?.LabelText;
            DateV = resultModel.DateV;
            DateV_LabelText = siteSettings.EditorColumn("DateV")?.LabelText;
            DateW = resultModel.DateW;
            DateW_LabelText = siteSettings.EditorColumn("DateW")?.LabelText;
            DateX = resultModel.DateX;
            DateX_LabelText = siteSettings.EditorColumn("DateX")?.LabelText;
            DateY = resultModel.DateY;
            DateY_LabelText = siteSettings.EditorColumn("DateY")?.LabelText;
            DateZ = resultModel.DateZ;
            DateZ_LabelText = siteSettings.EditorColumn("DateZ")?.LabelText;
            DescriptionA = resultModel.DescriptionA;
            DescriptionA_LabelText = siteSettings.EditorColumn("DescriptionA")?.LabelText;
            DescriptionB = resultModel.DescriptionB;
            DescriptionB_LabelText = siteSettings.EditorColumn("DescriptionB")?.LabelText;
            DescriptionC = resultModel.DescriptionC;
            DescriptionC_LabelText = siteSettings.EditorColumn("DescriptionC")?.LabelText;
            DescriptionD = resultModel.DescriptionD;
            DescriptionD_LabelText = siteSettings.EditorColumn("DescriptionD")?.LabelText;
            DescriptionE = resultModel.DescriptionE;
            DescriptionE_LabelText = siteSettings.EditorColumn("DescriptionE")?.LabelText;
            DescriptionF = resultModel.DescriptionF;
            DescriptionF_LabelText = siteSettings.EditorColumn("DescriptionF")?.LabelText;
            DescriptionG = resultModel.DescriptionG;
            DescriptionG_LabelText = siteSettings.EditorColumn("DescriptionG")?.LabelText;
            DescriptionH = resultModel.DescriptionH;
            DescriptionH_LabelText = siteSettings.EditorColumn("DescriptionH")?.LabelText;
            DescriptionI = resultModel.DescriptionI;
            DescriptionI_LabelText = siteSettings.EditorColumn("DescriptionI")?.LabelText;
            DescriptionJ = resultModel.DescriptionJ;
            DescriptionJ_LabelText = siteSettings.EditorColumn("DescriptionJ")?.LabelText;
            DescriptionK = resultModel.DescriptionK;
            DescriptionK_LabelText = siteSettings.EditorColumn("DescriptionK")?.LabelText;
            DescriptionL = resultModel.DescriptionL;
            DescriptionL_LabelText = siteSettings.EditorColumn("DescriptionL")?.LabelText;
            DescriptionM = resultModel.DescriptionM;
            DescriptionM_LabelText = siteSettings.EditorColumn("DescriptionM")?.LabelText;
            DescriptionN = resultModel.DescriptionN;
            DescriptionN_LabelText = siteSettings.EditorColumn("DescriptionN")?.LabelText;
            DescriptionO = resultModel.DescriptionO;
            DescriptionO_LabelText = siteSettings.EditorColumn("DescriptionO")?.LabelText;
            DescriptionP = resultModel.DescriptionP;
            DescriptionP_LabelText = siteSettings.EditorColumn("DescriptionP")?.LabelText;
            DescriptionQ = resultModel.DescriptionQ;
            DescriptionQ_LabelText = siteSettings.EditorColumn("DescriptionQ")?.LabelText;
            DescriptionR = resultModel.DescriptionR;
            DescriptionR_LabelText = siteSettings.EditorColumn("DescriptionR")?.LabelText;
            DescriptionS = resultModel.DescriptionS;
            DescriptionS_LabelText = siteSettings.EditorColumn("DescriptionS")?.LabelText;
            DescriptionT = resultModel.DescriptionT;
            DescriptionT_LabelText = siteSettings.EditorColumn("DescriptionT")?.LabelText;
            DescriptionU = resultModel.DescriptionU;
            DescriptionU_LabelText = siteSettings.EditorColumn("DescriptionU")?.LabelText;
            DescriptionV = resultModel.DescriptionV;
            DescriptionV_LabelText = siteSettings.EditorColumn("DescriptionV")?.LabelText;
            DescriptionW = resultModel.DescriptionW;
            DescriptionW_LabelText = siteSettings.EditorColumn("DescriptionW")?.LabelText;
            DescriptionX = resultModel.DescriptionX;
            DescriptionX_LabelText = siteSettings.EditorColumn("DescriptionX")?.LabelText;
            DescriptionY = resultModel.DescriptionY;
            DescriptionY_LabelText = siteSettings.EditorColumn("DescriptionY")?.LabelText;
            DescriptionZ = resultModel.DescriptionZ;
            DescriptionZ_LabelText = siteSettings.EditorColumn("DescriptionZ")?.LabelText;
            CheckA = resultModel.CheckA;
            CheckA_LabelText = siteSettings.EditorColumn("CheckA")?.LabelText;
            CheckB = resultModel.CheckB;
            CheckB_LabelText = siteSettings.EditorColumn("CheckB")?.LabelText;
            CheckC = resultModel.CheckC;
            CheckC_LabelText = siteSettings.EditorColumn("CheckC")?.LabelText;
            CheckD = resultModel.CheckD;
            CheckD_LabelText = siteSettings.EditorColumn("CheckD")?.LabelText;
            CheckE = resultModel.CheckE;
            CheckE_LabelText = siteSettings.EditorColumn("CheckE")?.LabelText;
            CheckF = resultModel.CheckF;
            CheckF_LabelText = siteSettings.EditorColumn("CheckF")?.LabelText;
            CheckG = resultModel.CheckG;
            CheckG_LabelText = siteSettings.EditorColumn("CheckG")?.LabelText;
            CheckH = resultModel.CheckH;
            CheckH_LabelText = siteSettings.EditorColumn("CheckH")?.LabelText;
            CheckI = resultModel.CheckI;
            CheckI_LabelText = siteSettings.EditorColumn("CheckI")?.LabelText;
            CheckJ = resultModel.CheckJ;
            CheckJ_LabelText = siteSettings.EditorColumn("CheckJ")?.LabelText;
            CheckK = resultModel.CheckK;
            CheckK_LabelText = siteSettings.EditorColumn("CheckK")?.LabelText;
            CheckL = resultModel.CheckL;
            CheckL_LabelText = siteSettings.EditorColumn("CheckL")?.LabelText;
            CheckM = resultModel.CheckM;
            CheckM_LabelText = siteSettings.EditorColumn("CheckM")?.LabelText;
            CheckN = resultModel.CheckN;
            CheckN_LabelText = siteSettings.EditorColumn("CheckN")?.LabelText;
            CheckO = resultModel.CheckO;
            CheckO_LabelText = siteSettings.EditorColumn("CheckO")?.LabelText;
            CheckP = resultModel.CheckP;
            CheckP_LabelText = siteSettings.EditorColumn("CheckP")?.LabelText;
            CheckQ = resultModel.CheckQ;
            CheckQ_LabelText = siteSettings.EditorColumn("CheckQ")?.LabelText;
            CheckR = resultModel.CheckR;
            CheckR_LabelText = siteSettings.EditorColumn("CheckR")?.LabelText;
            CheckS = resultModel.CheckS;
            CheckS_LabelText = siteSettings.EditorColumn("CheckS")?.LabelText;
            CheckT = resultModel.CheckT;
            CheckT_LabelText = siteSettings.EditorColumn("CheckT")?.LabelText;
            CheckU = resultModel.CheckU;
            CheckU_LabelText = siteSettings.EditorColumn("CheckU")?.LabelText;
            CheckV = resultModel.CheckV;
            CheckV_LabelText = siteSettings.EditorColumn("CheckV")?.LabelText;
            CheckW = resultModel.CheckW;
            CheckW_LabelText = siteSettings.EditorColumn("CheckW")?.LabelText;
            CheckX = resultModel.CheckX;
            CheckX_LabelText = siteSettings.EditorColumn("CheckX")?.LabelText;
            CheckY = resultModel.CheckY;
            CheckY_LabelText = siteSettings.EditorColumn("CheckY")?.LabelText;
            CheckZ = resultModel.CheckZ;
            CheckZ_LabelText = siteSettings.EditorColumn("CheckZ")?.LabelText;
            Comments = resultModel.Comments;
            Comments_LabelText = siteSettings.EditorColumn("Comments")?.LabelText;
            Creator = resultModel.Creator;
            Creator_LabelText = siteSettings.EditorColumn("Creator")?.LabelText;
            Updator = resultModel.Updator;
            Updator_LabelText = siteSettings.EditorColumn("Updator")?.LabelText;
            CreatedTime = resultModel.CreatedTime;
            CreatedTime_LabelText = siteSettings.EditorColumn("CreatedTime")?.LabelText;
            VerUp = resultModel.VerUp;
            VerUp_LabelText = siteSettings.EditorColumn("VerUp")?.LabelText;
            Timestamp = resultModel.Timestamp;
            Timestamp_LabelText = siteSettings.EditorColumn("Timestamp")?.LabelText;
        }

        public Dictionary<string, int> SearchIndexCollection()
        {
            var searchIndexHash = new Dictionary<string, int>();
            SiteInfo.SiteMenu.Breadcrumb(SiteId).SearchIndexes(searchIndexHash, 100);
            SiteId.SearchIndexes(searchIndexHash, 200);
            UpdatedTime.SearchIndexes(searchIndexHash, 200);
            ResultId.SearchIndexes(searchIndexHash, 1);
            Title.SearchIndexes(searchIndexHash, 4);
            Body.SearchIndexes(searchIndexHash, 200);
            Status.SearchIndexes(searchIndexHash, 200);
            Manager.SearchIndexes(searchIndexHash, 100);
            Owner.SearchIndexes(searchIndexHash, 100);
            ClassA.SearchIndexes(searchIndexHash, 200);
            ClassB.SearchIndexes(searchIndexHash, 200);
            ClassC.SearchIndexes(searchIndexHash, 200);
            ClassD.SearchIndexes(searchIndexHash, 200);
            ClassE.SearchIndexes(searchIndexHash, 200);
            ClassF.SearchIndexes(searchIndexHash, 200);
            ClassG.SearchIndexes(searchIndexHash, 200);
            ClassH.SearchIndexes(searchIndexHash, 200);
            ClassI.SearchIndexes(searchIndexHash, 200);
            ClassJ.SearchIndexes(searchIndexHash, 200);
            ClassK.SearchIndexes(searchIndexHash, 200);
            ClassL.SearchIndexes(searchIndexHash, 200);
            ClassM.SearchIndexes(searchIndexHash, 200);
            ClassN.SearchIndexes(searchIndexHash, 200);
            ClassO.SearchIndexes(searchIndexHash, 200);
            ClassP.SearchIndexes(searchIndexHash, 200);
            ClassQ.SearchIndexes(searchIndexHash, 200);
            ClassR.SearchIndexes(searchIndexHash, 200);
            ClassS.SearchIndexes(searchIndexHash, 200);
            ClassT.SearchIndexes(searchIndexHash, 200);
            ClassU.SearchIndexes(searchIndexHash, 200);
            ClassV.SearchIndexes(searchIndexHash, 200);
            ClassW.SearchIndexes(searchIndexHash, 200);
            ClassX.SearchIndexes(searchIndexHash, 200);
            ClassY.SearchIndexes(searchIndexHash, 200);
            ClassZ.SearchIndexes(searchIndexHash, 200);
            NumA.SearchIndexes(searchIndexHash, 200);
            NumB.SearchIndexes(searchIndexHash, 200);
            NumC.SearchIndexes(searchIndexHash, 200);
            NumD.SearchIndexes(searchIndexHash, 200);
            NumE.SearchIndexes(searchIndexHash, 200);
            NumF.SearchIndexes(searchIndexHash, 200);
            NumG.SearchIndexes(searchIndexHash, 200);
            NumH.SearchIndexes(searchIndexHash, 200);
            NumI.SearchIndexes(searchIndexHash, 200);
            NumJ.SearchIndexes(searchIndexHash, 200);
            NumK.SearchIndexes(searchIndexHash, 200);
            NumL.SearchIndexes(searchIndexHash, 200);
            NumM.SearchIndexes(searchIndexHash, 200);
            NumN.SearchIndexes(searchIndexHash, 200);
            NumO.SearchIndexes(searchIndexHash, 200);
            NumP.SearchIndexes(searchIndexHash, 200);
            NumQ.SearchIndexes(searchIndexHash, 200);
            NumR.SearchIndexes(searchIndexHash, 200);
            NumS.SearchIndexes(searchIndexHash, 200);
            NumT.SearchIndexes(searchIndexHash, 200);
            NumU.SearchIndexes(searchIndexHash, 200);
            NumV.SearchIndexes(searchIndexHash, 200);
            NumW.SearchIndexes(searchIndexHash, 200);
            NumX.SearchIndexes(searchIndexHash, 200);
            NumY.SearchIndexes(searchIndexHash, 200);
            NumZ.SearchIndexes(searchIndexHash, 200);
            DateA.SearchIndexes(searchIndexHash, 200);
            DateB.SearchIndexes(searchIndexHash, 200);
            DateC.SearchIndexes(searchIndexHash, 200);
            DateD.SearchIndexes(searchIndexHash, 200);
            DateE.SearchIndexes(searchIndexHash, 200);
            DateF.SearchIndexes(searchIndexHash, 200);
            DateG.SearchIndexes(searchIndexHash, 200);
            DateH.SearchIndexes(searchIndexHash, 200);
            DateI.SearchIndexes(searchIndexHash, 200);
            DateJ.SearchIndexes(searchIndexHash, 200);
            DateK.SearchIndexes(searchIndexHash, 200);
            DateL.SearchIndexes(searchIndexHash, 200);
            DateM.SearchIndexes(searchIndexHash, 200);
            DateN.SearchIndexes(searchIndexHash, 200);
            DateO.SearchIndexes(searchIndexHash, 200);
            DateP.SearchIndexes(searchIndexHash, 200);
            DateQ.SearchIndexes(searchIndexHash, 200);
            DateR.SearchIndexes(searchIndexHash, 200);
            DateS.SearchIndexes(searchIndexHash, 200);
            DateT.SearchIndexes(searchIndexHash, 200);
            DateU.SearchIndexes(searchIndexHash, 200);
            DateV.SearchIndexes(searchIndexHash, 200);
            DateW.SearchIndexes(searchIndexHash, 200);
            DateX.SearchIndexes(searchIndexHash, 200);
            DateY.SearchIndexes(searchIndexHash, 200);
            DateZ.SearchIndexes(searchIndexHash, 200);
            DescriptionA.SearchIndexes(searchIndexHash, 200);
            DescriptionB.SearchIndexes(searchIndexHash, 200);
            DescriptionC.SearchIndexes(searchIndexHash, 200);
            DescriptionD.SearchIndexes(searchIndexHash, 200);
            DescriptionE.SearchIndexes(searchIndexHash, 200);
            DescriptionF.SearchIndexes(searchIndexHash, 200);
            DescriptionG.SearchIndexes(searchIndexHash, 200);
            DescriptionH.SearchIndexes(searchIndexHash, 200);
            DescriptionI.SearchIndexes(searchIndexHash, 200);
            DescriptionJ.SearchIndexes(searchIndexHash, 200);
            DescriptionK.SearchIndexes(searchIndexHash, 200);
            DescriptionL.SearchIndexes(searchIndexHash, 200);
            DescriptionM.SearchIndexes(searchIndexHash, 200);
            DescriptionN.SearchIndexes(searchIndexHash, 200);
            DescriptionO.SearchIndexes(searchIndexHash, 200);
            DescriptionP.SearchIndexes(searchIndexHash, 200);
            DescriptionQ.SearchIndexes(searchIndexHash, 200);
            DescriptionR.SearchIndexes(searchIndexHash, 200);
            DescriptionS.SearchIndexes(searchIndexHash, 200);
            DescriptionT.SearchIndexes(searchIndexHash, 200);
            DescriptionU.SearchIndexes(searchIndexHash, 200);
            DescriptionV.SearchIndexes(searchIndexHash, 200);
            DescriptionW.SearchIndexes(searchIndexHash, 200);
            DescriptionX.SearchIndexes(searchIndexHash, 200);
            DescriptionY.SearchIndexes(searchIndexHash, 200);
            DescriptionZ.SearchIndexes(searchIndexHash, 200);
            Comments.SearchIndexes(searchIndexHash, 200);
            Creator.SearchIndexes(searchIndexHash, 100);
            Updator.SearchIndexes(searchIndexHash, 100);
            CreatedTime.SearchIndexes(searchIndexHash, 200);
            SearchIndexExtensions.OutgoingMailsSearchIndexes(searchIndexHash, "Results", ResultId);
            return searchIndexHash;
        }
    }
}
