﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    internal class Day_3
    {
        public static string INPUT1 = "vJrwpWtwJgWrhcsFMMfFFhFp|jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL|PmmdzqPrVvPwwTWBwg|wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn|ttgJtRGJQctTZtZT|CrZsJsPPZsGzwwsLwLmpwMDw";
        public static string INPUT2 = "vJrrdQlGBQWPTBTF|fcpTMnMqMfTnZpgMfPbFBWzHPpBPzbCPPH|mcVMfcsqZgmgVcmfgcmZmqZNJhrlrdhNhDdrRRJSvDTRhJlD|pMFRmLwHMbRPmMbPPddvqqrrNSTFVttdrN|hgfpgCGZcjpcgfvNtdrtjvrdtSrd|gZgsBBBlZggBGhsfhpzlzLDLmLRDRMLDPw|hChhMFCvqtTMwbSSHgTZWHZd|jjBNPjJJNfsNjVnVJJNcNfPwGbSbDZnZZgHrddwHrrgWGb|mBBRRmBBQBmNJWhCzqllzhRCCv|lQgpngNgQvHdSgWwjMRmDjmMDHmm|zCLVzfzzbbCzsZZPbZPLfFJJMDWWRcDsmJRcjmwTmlRj|BblftzBtlFznptSQQQppNG|wJJwqCtCGRcVlqlM|BQpppjBQLczTrvHRjH|QQQFnmQWWRfnpQBpQpfDCwCdbPDCwbNNPtdJPCZw|gpJjshBpgjZGppJqBGJjJZzTwzTmcvzwwcmvwsCFdmcF|WPSSWWSQLVdDDfWltDWLPfttvFCVmzCCTFnmwcnnnCTCzVVv|tLldLltDQfflrRWNqBRjgHBpJNZjHj|bzVJjVnjbCGVLZQLmmsJZZQQ|RrwwzhPScWSwrhvZZvZlZvvSTsQS|HwFhzFWdPHfcPwPWPdhWffnngpjtnjgtpnfGCGnG|CPwQtftDQfPDBPBCfDDDCDptszcpVVddcRczVLVdccRGrLWs|FqlSnhlqhmhMbHqqSQlHbcrRrsWzRdzdWVzLRGRrVF|MbQmSnHZhqZMQMTJCttjCgPCwfgDwT|CCSpvHtZHSwftFtdtbfR|QJmNPmjjJNgNVNSzDlmRqbWlqWWfcqfWqbwfqR|MDhJzmSMDmsZrLhssrvh|ZhznnrLzcHhHSjsjSBSsBnSS|dTwqDdqDRQjNdwqjldggDvBJfmBfTSBbBSvfSJsmff|DjCldNglVwFVgZHHHzhCMcLhMC|vBnShjwwSshmQPmtJLpJtn|rDLFCWrClWCMWWVrbFVJqpQqpHmtbzJPQzJmzb|ZMCCDCMNrTWTrgScgGRhsvcsGLSG|LQpJglQQRjQsppfsQbjfbQlBgBhFhrvghhZCdPZZZthPgv|zVHDMSWVVMVWDzmnVMHDSMMzZvNFFrFvPCdmdFdNdrBPZhhd|ncqqSzMVCcGWVSCTWCDcVTffLLLbJsLLsRLblRQTps|zjGzLQtFzzRgwwLhVrqw|dfClCdHZsmffZDWlBZHCDBmhJbqTgbwgqbTnwrgrqRbT|HsdwPCsWDpDsBpfdWdHldWpsGvvccPvGcvzQvFQvccjNztQt|wmVVgFPrFdwJrlNHQHSHCCHL|tWBtvnBqZZMpcvmmqMBRCQQLCLWCHfNQQCSGWL|BBsnmcpqPswFsTws|BQRpFPJJJJPmPRqZNFVhcczHHzggwjBhghgzHw|snTsTLtrlvSSSslsGdcwmjhgggvjHhmH|nSsWWTtCbbDSnlRRZCfFRNZmCVJf|tRRMCWLtJWQLqLrmLHVLqmqh|JszPjSbGbsnGnSZprVpFhvFqvhrqZZ|zgbGSDBbPsTgbDBzzSDnDnPTcWlWJCQlNttNwwwMcMctcW|hlVRvPvzqqtRdwRRJsst|HHVNVBMBjHLTjVjwDjsbjJwbdmbbss|NBZHMCNVCCpgLTWggBpgNLTvqCPnGhQhCCGlqlhfcvvGfn|mwbfbfbDCqRJZRbCSvmfWTQFczTznnnFTFnrzJsz|BdhHlLjpjjjncSprnsSFWS|ljhVBPjSdHPRfZRZDvVRZM|tGqbqBSsntRgNqwNNVVHVN|hclFvJZvCDFppDpZpHNggMTwdlrMQNVgHM|CCFmcZLDFpvzZhCFJvZvmwjSRWsBLWsnfWjRRGGfnsst|GdGQQFdcMPwMdLFvWsNWFDLfss|SqjhtjnrbVznSztSqtzpjztVvTmNNmmfMMfDDMDDNTqfgsqv|rVhhZjppVrhpVzRbjSnzHPMwlJCJQdcRPPlPPcHJ|JVQLVgVZghFtFlhghtvSzsddmrdvssmzSWtd|HTMJCBMCjnwNBnCbTNwMdWfzvzsrsvffWbdsmfPr|BGnnpDnTjjHJwDBNpqlFQVQFQclcRFQqpR|BRhbrQDttbTTtRDtTRRzLHWZLZHGSqWLCBNWqLNL|fwFPPSjmsmJGLsNH|dvfSdvfVMjPTttTzczgTcd|dZgggwzgvsggtdstZTZgdfnhSJSSJDDhnDBdppnGnhSp|VQWRQWVCRLFGnThJCpFJ|LbmmbQVcHcmmlWjmVlVQNVRzvwwZvTrsrNwNwzZrMvfsqt|lDZQSlHDbLccRPQhCNhG|gtsntgvdvBvvqgsTgBggdrWRNzPhWczPbWcdWCccGGGP|sTBttvrFnnMTMJngbqfLlZLpwFVljwppZZDl|zNNNgqpgmLgqlHBHsMGslH|WdWFrFwhcwWRwhddcRWcdQbcDDslzBDszsHbGBDfbHfzVlVl|ZvhRrvPQwvWFQRZvFdJttSPgCmNppCNzJnJS|fCzRRNGfqNRvwpQhwrGcwZZT|gJnStgMmLhdHndSSTjcTrTpcmrjjcrrw|FFJBbdddFPPhFFNWCF|btrHRSBBSNLLRPLwhbhpqpfWhQppWZ|zCzTvvmgDvgDZhqWZZthtDZh|ttTjMsvCgRRLRSsBRG|LsSFFTTDWdCsmFTlLSsLDDRRQCvhpRQGNGQBJBhGGMNB|zqPtqZnjPPrPvJHBMHrJrMpv|VbqfjZfwgtfjPgZPgtwDLTLcTlcFdWLdcdVTJF|pfMCDmpHbdMQQdQFFG|gdjldRsVFRntQnqR|rlJVsWgWPWjsslSpDbScmSDPHfCd|lnFFGgBFBslDFGbFSjnNTjjppSrQHhnT|zcvmCRcvZmcZzWpTQhQrrTSPtHWH|CRccrZJmdJlwDJwgswGg|hllrrDzggGppgSSLNWgW|jlTlPwwqjjntVpWWPNnP|wjjJqvQjJjQJbTjlFqhBMzfDDmMCGBMHDCGb|jvQPhhtCRtfmqHHjqHHJsl|FFSTcBTBTMwFGCTwMTcGwTVnsHSJzqqJJJplmlpJHszZZzZD|dLMdVMNGBdGFMTNTRRLrQWCQhgWQbhgf|gdRgdgzzrvrzggDwgDGpPLzrbNljMTsbWWjWjZbTjLZMWcWj|tFfCQHJJnJMJTJjNNMjl|HmtffVttqHQmBCBQCqfFnCwRqpDvPRrGppRggNzdwgzp|DHSqzQbzWlRLDzMZNpVLgnpNLggw|cZcdTmPPthPdsvvdhPGTvJgwnpgjjTgNNwMVngNBjNfn|PPdJPvrtGtcFdFFchDRHDqHzZWSQQCrQWQ|BcgnLBLsFvRnGRRRlzfJbbPJzwHPwPFz|hCDjWMDVNfVllfzddw|qqMqpWCMjDTWNWTBLpgsgLvZwtGLLg|zczPgpGzhnbmbchhHwqwhSwfwHCFWw|VJdmVLlLdVJSJWHSTFwH|rlttQLVLdvvZpgcGbmDrzGMD|WSvtpqqtqccttVQpVvJNJSVNCmTlnCWwTTnWlBBBjwCBTlTP|ZgfPHfPfMHsDCwnlGBwTMGBM|rgdffZhPrrLsdLZpvcFSJJNvpJhcJv|qVdqJGvzgJzJgwzgWvdJzpblcRRWmLFFcLBmllFRRMRFRH|TGGSsSssNPTSLlRLcPHMmnPB|tTjTZtNGhrCjQNCjQQDTCSjZvfJbdgqrdpwqfVzwgzvdvVgb|VTmwcTVSMHwbMwbDVBTcMpJfpfnWqdJbZpJldfsjZn|hNtPhtzFzPQGCCGFFCGtnqQqWZWplsjWdlnlldJn|vRCRzvvFFFvhrRthPtLrtNGSwBVDScDSgHHjwwcBgSgTSL|dWCsWbWWchblsmbWVZqqsSpsGfBqBVBB|DtTtjPJrgjjtTTwgPwwjrTgnLqSBZQLqngQppqnfBVQfGp|PJPwwtDwHGGJtJRFHmhCFRCvdmHR|mMsMJSCjllsSSmBBclsMsJHDbcHqqbHpqHGbDZHbqHpb|RnQnGVnzGzFQgzWzpzvpqDHW|QVhRTfGLLFGTTFFwhnQVNfFwJsJsMjsBMrlsjrJlPSPlTrls|JNMJSVSGVCjnWZMZWWcH|gLTcqbqhqbbgzgnjpnjjWHnP|wqlbcrfTwrvcLBwwRtJwsNRstRsCCN|MlBssQBchZDLNJZgmvGg|fdzHMfHSzSprfgSvvJbmvDGNDW|PCHTRfjHnzHMzzfrCPCpMTlFhcFstqVwVCFllQcBtqss|TtFnnFJfDhtdfJJcFtfnsfcFjBjLDjHrDLrCjMjwCLLrZjrS|qQmWmQzvWpRQGvgpGGRGRzmWwZMwBLCHMZjbBBCLwrHSLrqr|MRllgRWWMlsJFnlFclJT|SRRrRDRBRTdbdMRZBZMprTCJCnWGvChJGzLSWWzsGhCs|wwqHPtFwjwTHLHvGTsGW|FlPtqTNVcTVtwtmjRbBZfQbfZbQmRRMR|WSWfQttffsHSfRRRStfnCsQQqlJpbhnrnmNzJbzqNbbrpmnb|FGFPddBcBwDPzpzbWlpzDbbh|ZPdPPLMFdGwFFGdwGdZwcZgTtSTVCsRRSgSRTQWTTtCTtH|vHsfGHTvSvHHHsGHctMgtHrJwbJJwrjgbrdzjWCrdrrw|hqZRLmmZpFhcLhFmrzJQbzzmQQJWJJbm|LNZFcpPlhBRhqDDllRtnMssGfBsnttGTnttT|VDVrLrZZcjrhhFrZppGlglGMPFwFWNQw|bzszSBHBWNGcscpN|TJqBqSfTBBqBHzJqddBqzcLnLjnhCRTvvRrnDrvrvZRn|GLzrNWbtMptHDmNDglgmlD|fZtcfCRvtBcQjdjgmmjj|RhBhhqfSPPpttrnPnVVW|BhVRJGwWqtHjZqTDLZ|gQnfpBdPNpQrPNSfBdndnpTTDFZttDLLzZzTzCLNLZZD|mQQPsgrldpgdBQgSbGVcmcRwGMWhwVwW|DrLCctBCLQtSSQcLbcQHWvvvlWHHnWlWBlNRRB|wqdmpgqsZhzGphwwpZGsppRvfnJsWfHWvfFfWFsfvlNN|mwmhVppTqpGqpNZpqTbSLLttDrDDtPQTtr|qwqmgnglDnlgtQzQJzJQhmWQ|pTpTpssdsVvNsdTSZGdSdjvCRcqcRcVWVczhWChtchzWcR|sGTvPqZvSGdZZGdsvNGdPHrFHFBDlDLwPgBFLLBB|BBBGsGGBrBBrqWVqRnWBBBWpzFwMhjMFSFPzzSwPFPpzzFvg|HtCdDdDctZDtbHCffcbddbNfvjvFSPFjMhMgLwPgjbFhjFFj|NJTDdltNgCNDZJJZCDJZDfJtrWWnQGBqlRVVlrBsnlrqqmnr|PwZhgbZSWSqqGznv|tTPVVmptcsrNrsTNpjRzqfHvvGfGWjfjqGzHWn|RVRtVDRmsRtrctmJDtgBBhBhbFgJPFFMFJgP|jPzzCCPzTtTfzrRtgSNVRHvFQVvbpQppVN|sSnDlBGBwJbFNplVlN|cLwSwdMhSwcBcsBZgWjCTCWfCLffrg|RSNPvTTNqFTSvNrSBvBGJGzmFMslgCMJCgmzlc|fDVfpptLWQfnVLffVHbQDQCclJzGGCtGmmGJmzMshzGh|VfQnWZfZDbdnVHWcfWnfHWVvPrTSNZqSwSqPjjvBwRqrNS|FLRpmRwcpjfzjSnD|tGvPNvBnPQggPQQvPgNHDjSSjDzzthjzfHrjlT|JGqvWNCCGQBWGBQvVLsCMMRLRnRMnwMc|fGJbzgBffCGpPGDVnG|mcTccshvbbdRNRsNjdLjnVlHVnHLqVpDpDqD|wdmsWvWssbZTcWvRhfzMQtrzMgrfrZJgfQ|NfSbvZHZNRSbQbbQgZrMjhLwMrjLjwHLCmmh|NTWdJBFcWJFcdsFJqcqPwqmjpMrLCMpLMwLP|dNJctnFBVfSGgvnfZz|GSnRJfGfRJgMDMGWnfzdmptpFJppLvwLwvLt|hbjZzrQbblqcLtpwlHvFplTH|qrzqbschrQCqqjPcCVcCGDfGMWDgWNGDDSfgnf|vmMpCdTndCvMdmnFcCRJWBJGcZJRJB|NDNwGzshPLrwVVNsjswhGzjFSfFFQQRSJWRBFcFRfsWFQB|NwNhNjVzhhzzrgzdqqvqtnqvlqdggG|MdPLVSSlMMVMmlLBBLFdvZNWqWztStttRRNqzqNGTq|DhJfhghhCgwChJgJwHHzbsHpnZRtTWqqfZRGTnWTZtNqNRWR|hwHpJbprwpQhDHDCbCCzsClBvrLMVFPvmPlMMVMdLrvj|DssDrqRsWsNfzfsWLRzjgTdBlgzFpMlgTFTglT|ttCZnSQmSQmgjGQGQgDlBp|bhDnCmbwVmCwwtZttPwbRWsRJcqWJfcfsfrqVrqq|ldBgTMTRvBDVnCCCTdSRTqNjbjSbPPPPqtfPqtPJFJ|cZHZrszLrrrZHrbNjNtbJCfqNJLt|GZzCzWZGGsGzmzZcmGssZzZVvnVdBDddRRDnVlWgRTDdBM|RjNrrjwGDDqqGJsHtzpMHHGz|QCbWgbShmBCCPClmmWFHzJzTbDdsMJsTtpTD|fffQfnSCWDBfhCDLRrNrwcrqVqwNqn|zmRrDRzqjmLLHzDjLsHLflJlVVJlWWTDTfdMtlWJ|pPQQnbvSpvNbgfgfVtMVJfgdtG|SnpnVFcPnNnPvpNSFNSbhHLhrjhCqRsRBRrHCLhzmC|CZZzlnCZNlGGcbVrbtVlMtct|MgFQDFgQRLLHhJgDFqQJQLgdtVTrttSrPSmcbmTtvSqvVSTV|hFQDDfMDfLgHwWfBzWwwsZGW|bHVDdHVHTPMvnSQnWSDQgDmm|GhrCJfbfrhfbRJcqGqlwZtnBRtBWSQgQWWnWQW|lfcCrqJhlfFqphpplNCrNVMPMPLbsLPLzFVHVLsVdz|VDhFCZhtFdPqwwcp|SvnvHNNnTvbwNNgnHwTHgwBTLcdqmmfmqLGmmTRLPfpdGP|BNWsHJgSnwgMMgMBBWMDVJjtjZrDJZzztJhjQr|HDsSHLRnpjbpbbRDbqLjLjjGGVffMVGMdvnfMcNvfBBGcB|TCzQQztwwNTMqMdBVv|hCQWmtCzZthPPZPrLjSbJqjSjLLFjLpr|ZrrZqJDcZSCFLLHBFcjjHF|TgvnDTlTtQwgBfwwwzLjGLdF|VbnVngMtvDTTVMQDQMDQlsbZJChCmCPhprrZqhqZSZPJ|glMGHBJTJJTplgwcCgcqcFhhbWncFm|sSswtPfRDmWcCqfchq|RZSdSzsVzNPSwSSQsdzSSQpGLjJTMpBGrJrLLrplZBpG|WQqqwLqQlnlWDwtbVbtCNfVbpV|dFTRjBPhcBgBrFhTPhrbVptJpNNbbtJCbJSL|hjcmcRmgPPcRcPDmHHzGLWmsDmzH|rWFmrRmmccSZJWvSLZTH|hDPhGbhSjtbpqJLvJHjLHTqj|pnplBlfBPPhlgfDbDhglPMMrwrRRSSncwccQzddzmC|LbccJCGzbcCJcfGczcnmNnvNmZNLSDZZWPWS|dwstRhTsrsFddPZqvNWP|BBggRrQstBwBRTHWTprRCHHGVljfCGCfcljHjbGV|FHVBSVDvnsFDwwSVwwvGVSMFWhWcWptMWchWMtPPcWtNNWcj|TgqJrJTRmRCNrbcLjprLnp|qQTlfdlZQgmfqqnFVznvQwvnsBsV|TGpDDMQGMZNtfvDJdtWd|jbrmstmllRmNvVhmmvJVhv|tbrRzFFLlRrjFlLlTQgLQwwLMwgTZBTB|QFgFWQQfSgLFGmtnnVmqCPWmPH|TTzjgTbRRqnRsCPCsP|NDMMgZjzcJvbjhMcjZbbbJJNpdpBfBvSBBQwBSQLQSpSplBG|zcRNsQSSMjRsNNZZFBLQHHFFBPWF|tvwCtgvqLJNnNBCH|fNNwqrqNMpTrDlcs|MMHMVPRJHJWvqzWctbtQQdQz|DFfNFffDnTllfTfFfmzsjqcdtQGQpbddQQbssn|mlFNCgFNNNLrmLFCThhhzJBvhSJPVhMgMh|PWjhljbHFhjbFMWhjbPfhbTGZvlGcGlCLvvwtGCNZGvc|SRqBqBrmQWQrgQrrqrJBLZNccLNZmTCtvTGtCvCt|rJDzDSSBrzdqQWDPHFMjMFdjHMVnbM|qqLwvvtrLFqqfqrjjjdBZfBCBBJdlT|ZGZpRZHbQDzDWRRRVdBzSSlBdzjjzdJJ|ZGpgNDQmWGDRmRpZMQbvPPtnnFnLsstFmnFrPL|TdhcfZhdZZdpdbPWttCWrrCN|MBMMqRLgpGpFFWbNsvLwvCPCCP|mpBMnBRMBGqJfZcfZZHZlhfm|CdmGdnMcMwHjhDtFFnrj|vPbVbPBPPpgpgWJpvTjqDZZqSHqVZShrDj|BppjjgvbJjbpNbzPfNcGCLlCRcmLLflllGcc|qDtgVttGFtlslStS|gCZbbHCjvJbZjCbJhHhHJrZcslJcLzLllcLNFssMSsTlSM|CWbWrZgWBQQBBpfdPm|hstPtCGtltlTClllPJLScVdPdJjLPJMV|NHRbDZDQSDFFjjdJ|RqbQpgBmqZvqZNQqgZmmbszpTtthtCswhjslwwpTWC|CVdwBJJdppbbwdBVrJbrJbGPlMFSLrjrPjmPFFmPRRDF|NNWHHhNZTcQWhnNFlmSSlRmLjnPPRF|qWsccHTZccsNsZcvTcNtStpBtbdVwpfBwbVCBq|lPQHNJhMPMPFlNMHBqZBwQwQwQZwcCqw|bWddDzbWbftdDSDbgttgnSDWccLwcvBczqcqGZzLccZTZwwc|spWrssWrnDtDpfSWDtsFqlFPjNMjRJVVNNPJNp|bCCfcWVLTHfSSdHwhH|sGQSZSzQJmmQsphwHHHsndnpHN|zPSqrmZPFCvFTbWMLV|tLtVBGLJqGqVGbzGSCsSsSqQsFvZCSQv|gRgdWlHTBHgjjHlWpWjWjrwdCfQRZFSssQQQZmQmMSvZfFMQ|lPHlpWgjTldprNWHNNdHjTctcLbVcnNJJGbVzBhnbhhJ|zVrSwzzJbVrbqFCVVVwVCztWDDtfTZsWDZTLZZmSWsDm|bpgHlgBbbGGGglBGRNvMpWfTDjmDfWDjfRZZWLtmZs|bGbvQHMpQccFJPPh|VGqCPmPjfGqCdMqVMhjhmPChDJDJzvrrbrBvrdrpnJDpJDQr|TSRsgHRSFHTlHvJvBDvvzlptbv|ZFLTsRRgZTgWscHTfWNWNPPBfGqmmMfV|TvTrrrCVCVwqjPrWfWhjfH|RRmgmnggltRgNpzRsdfqWWjdFdvNHfdh|zZlRzDGGZmbmmZbvGJVccwCMVcVVTLwDwC|QPsNlvvvSccbbNQcSPvDVSvzTLLCgRVzCJgTJpgCpphgzh|MDqHwFrMffgFpgpJLzTz|ZtdrffBrdqmBBmfwMtDtQPPPbjcNvnllnlbNtScn|HbbbcpTHHMMqNTCddCVBQvgPzJPJWQBQjvpBvQ|FFrDGtntFFwhrRFDFthfRhRmSJPJvvJZjZjWJJvJQJnvWjjg|rtfFfLmLRmNgdHqcLNHd|FpFHCFWtFSnCWnBfJJfgMJDGHDGGsG|rhrLrrhLrbtZThLfgsfGNDfgTgNcDs|QmPjbdqjmbbbrmhQqQZrZStRdlnnFdlRzVVVWlnpzR|bBMwwjzhbjhssvsGZBSZLr|JFtnDtRzJtffJHWNtHncRRrvGZvSnllZZZsgvlnvVvlv|RRPHPHFPHHdcHtzNfMQhdCwbqCmbMChhqq|pWGdFSWwwjLdvgNNvggl|mTNbmRPHmmVNmvZhnhBssBlhnb|HPTzRPffJJNzjCFpDWDz|MHlgzsqHlbmzgsHzlsbcRWPdPtjZFqhGGdrPrjPJGrVP|vpwwvQwCnhNQpSnLdVtrrZGZtZjdVSdJ|hfffwvTpvLwDpCLvDnQDHbmRRTcWRHMWWHWMmWMW|WHlNHWWldjpwntnWBPpPQFZFBFhZBZCZ|TqqvgvmgfmvDVLLfqqLsrFBRhrrBFJQBGPgPZGCR|mcDbcDmzLcmDDzfVzTQNjNzNztdzjNdwSHlH";
        public static int PartOne()
        {
            var rucksacks = INPUT2.Split("|");
            int total = 0;
            foreach(var rucksack in rucksacks)
            {
                string firstHalf = rucksack.Substring(0, rucksack.Length / 2);
                string secondHalf = rucksack.Substring(rucksack.Length / 2);

                var valueAsciiItem = (int)secondHalf.First(x => firstHalf.Contains(x));

                //In case of uppercase, sum the difference to the lowercase char, minus the count defined, plus the diference to uppercase points
                total += CalculatePriority(valueAsciiItem);
            }

            return total;
        }

        public static int CalculatePriority(int valueAsciiItem) => valueAsciiItem >= 97 ? valueAsciiItem - 96 : valueAsciiItem + 32 - 96 + 26;

        public static int PartTwo()
        {
            var rucksacks = INPUT2.Split("|");
            int total = 0;

            for(int i = 0; i + 2 < rucksacks.Count(); i += 3)
            {
                var sack1 = rucksacks[i];

                foreach(var item in sack1)
                {
                    if(rucksacks[i + 1].Contains(item) && rucksacks[i + 2].Contains(item))
                    {
                        total += CalculatePriority((int)item);
                        break;
                    }

                    else
                    {
                        rucksacks[i + 1] = rucksacks[i + 1].Replace(item.ToString(), "");
                        rucksacks[i + 2] = rucksacks[i + 2].Replace(item.ToString(), "");
                    }
                }
            }

            return total;
        }
    }
}
