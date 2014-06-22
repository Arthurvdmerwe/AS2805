using System;
using System.Text;
using System.Reflection;

class As2805Message
{
  #region Header fields and Data Element variables
  public int mti = 0;
  public byte[] primaryBitmap = { 0, 0, 0, 0, 0, 0, 0, 0 };
  public byte[] de1_SecondaryBitmap = { 0, 0, 0, 0, 0, 0, 0, 0 };        // DE1: Bitmap, extended (b64)
  public string de2_PAN;        // DE2: PAN (n19)
  public string de3_ProcCode;        // DE3: Processing Code (n6)
  public string de4_AmtTxn;        // DE4: Amount, Txn (n12)
  public string de5_AmtSettle;        // DE5: Amount, Settlement (n12)
  public string de6_AmtCardhBill;        // DE6: Amount,Cardholder billing (n12)
  public string de7_TransDttm;        // DE7: Transmission date and time (n10)
  public string de8_AmtCardhBillFee;        // DE8: Amount, Cardholder billing fee (n8 )
  public string de9_ConvRateSettle;        // DE9: Conversion rate, settlement (n8 )
  public string de10_ConvRateCardhBill;        // DE10: Conversion rate, cardh bill (n8 )
  public string de11_STAN;        // DE11: STAN (n6)
  public string de12_TimeLocal;        // DE12: Time, Local txn (n6)
  public string de13_DateLocal;        // DE13: Date, Local txn (n4)
  public string de14_DateExpiry;        // DE14: Date, expiry (n4)
  public string de15_DateSetl;        // DE15: Date, Settlement (n4)
  public string de16_DateConv;        // DE16: Date, Conversion (n4)
  public string de17_DateCapt;        // DE17: Date, Capture (n4)
  public string de18_MerchType;        // DE18: Merchants type (n4)
  public string de19_AcqInstCtryCode;        // DE19: Acquiring Inst Count code (n3)
  public string de20_PriAccNumExtCtryCode;        // DE20: Prim Acc Num Ext, Count Code (n3)
  public string de21_FwdInstCtryCode;        // DE21: Forwarding inst count code (n3)
  public string de22_PosEntryMode;        // DE22: POS entry mode (n3)
  public string de23_CardSeqNo;        // DE23: Card Seq No (n3)
  public string de24_NetIntlId;        // DE24: Net Intl Id (n3)
  public string de25_PosCondCode;        // DE25: POS  Cond Code (n2)
  public string de26_PosPinCaptCode;        // DE26: POS PIN Capture code (n2)
  public string de27_AuthIdRespLen;        // DE27: Auth Ident Resp Len (n1)
  public string de28_AmtTxnFee;        // DE28: Amount, Txn fee (xn8 )
  public string de29_AmtSettleFee;        // DE29: Amount, Settlment fee (xn8 )
  public string de30_AmtTxnProcFee;        // DE30: Amount, Txn Proc Fee (xn8 )
  public string de31_AmtSettleProcFee;        // DE31: Amount, Setl Proc Fee (xn8 )
  public string de32_AcqInstIdCode;        // DE32: Acq Inst Id Code (n11)
  public string de33_FwdInstIdCode;        // DE33: Fwd Inst Id code (n11)
  public string de34_PanExt;        // DE34: PAN, Extended (ns28 )
  public byte[] de35_Track2;        // DE35: Track 2 (z37)
  public byte[] de36_Track3;        // DE36: Track 3 (z104)
  public string de37_RetRefNo;        // DE37: RRN (an12)
  public string de38_AuthIdentResp;        // DE38: Auth identification response (an6)
  public string de39_RespCode;        // DE39: Response code (an2)
  public string de40_ServRestrCode;        // DE40: Service Restr Code (an3)
  public string de41_CardAcptTermId;        // DE41: TID (orig ans) (an8 )
  public string de42_CardAcptIdCode;        // DE42: Card Acceptor Identification Code (orig ans) (an15)
  public string de43_CardAcptNameLoc;        // DE43: Card acpt name/loc (orig ans) (an40)
  public byte[] de44_AddtRespData;        // DE44: Addtl resp data (ans25)
  public byte[] de45_Track1;        // DE45: Track 1 (ans76)
  public byte[] de46_AddtlDataIso;        // DE46: Addtl data - ISO (ans999)
  public byte[] de47_AddtlDataNat;        // DE47: Addtl data - National (ans999)
  public byte[] de48_AddtlDataPriv;        // DE48: Addtl data - Private (ans999)
  public string de49_CurCodeTxn;        // DE49: Cur code, txn (a or n3)
  public string de50_CurCodeSettle;        // DE50: Cur code, setl (a or n3)
  public string de51_CurCodeCardhBill;        // DE51: Cur code, cardh bill (a or n3)
  public byte[] de52_PinData;        // DE52: Pin data (b64)
  public string de53_SecControlInfo;        // DE53: Security related control info (n16)
  public string de54_AddtlAmts;        // DE54: Additional amounts (an120)
  public byte[] de55_ResIso;        // DE55: ICC Data (Reserved ISO) (ans999)
  public byte[] de56_ResIso;        // DE56: Reserved ISO (ans999)
  public string de57_AmtCash;        // DE57: Amount, Cash oz only (n12)
  public string de58_BalanceLedger;        // DE58: Ledger balance oz only (n12)
  public string de59_BalanceCleared;        // DE59: Acct balance, cleared funds oz only (n12)
  public string de60_PreswipeStatus;        // DE60: Preswipe status (Reserved Private, normally ans 999) (an1)
  public byte[] de61_ResPriv;        // DE61: Reserved Private (ans999)
  public byte[] de62_ResPriv;        // DE62: Reserved Private (ans999)
  public byte[] de63_ResPriv;        // DE63: Reserved Private (ans999)
  public byte[] de64_MAC;        // DE64: MAC (b64)
  public byte[] de65_Bitmap;        // DE65: Bit map, extended 2 (b64)
  public string de66_SettleCode;        // DE66: Settlement code (n1)
  public string de67_ExtPayCode;        // DE67: Ext payment code (n2)
  public string de68_RecvInstCtryCode;        // DE68: Recv inst count code (n3)
  public string de69_SettleInstCtryCode;        // DE69: Setl Inst Count code (n3)
  public string de70_NetMgtInfoCode;        // DE70: Net mgt info code (n3)
  public string de71_MessageNo;        // DE71: Message No (n4)
  public string de72_MessageNoLast;        // DE72: Message No Last (n4)
  public string de73_DateAction;        // DE73: Date, Action (n6)
  public string de74_CreditsNo;        // DE74: Credits, Num (n10)
  public string de75_CreditRevsNo;        // DE75: Credit revs, num (n10)
  public string de76_DebitsNo;        // DE76: Debits, num (n10)
  public string de77_DebitRevsNo;        // DE77: Debit revs, num (n10)
  public string de78_TransfersNo;        // DE78: Transfers, num (n10)
  public string de79_TransferRevsNo;        // DE79: Transfer revs, num (n10)
  public string de80_InquiriesNo;        // DE80: Inquiries, num (n10)
  public string de81_AuthsNo;        // DE81: Auths, num (n10)
  public string de82_CreditsProcFeeAmt;        // DE82: Credits, proc fee amt (n12)
  public string de83_CreditsTxnFeeAmt;        // DE83: Credits, transaction fee amt (n12)
  public string de84_DebitsProcFeeAmt;        // DE84: Debits, proc fee amt (n12)
  public string de85_DebitsTxnFeeAmt;        // DE85: Debits, transaction fee amt (n12)
  public string de86_CreditsAmt;        // DE86: Credits, amt (n16)
  public string de87_CreditRevsAmt;        // DE87: Credit revs, amt (n16)
  public string de88_DebitsAmt;        // DE88: Debits, amt (n16)
  public string de89_DebitRevsAmt;        // DE89: Debit revs, amount (n16)
  public string de90_OrigDataElem;        // DE90: Original data elements (n42)
  public string de91_FileUpdateCode;        // DE91: File update code (an1)
  public string de92_FileSecCode;        // DE92: File security code (an2)
  public string de93_RespInd;        // DE93: Response indicator (an5)
  public string de94_ServInd;        // DE94: Service indicator (an7)
  public string de95_ReplAmts;        // DE95: Replacement amounts (an42)
  public byte[] de96_MsgSecCode;        // DE96: Message Security code (b64)
  public string de97_AmtNetSetl;        // DE97: Amount, net settlement (xn16)
  public byte[] de98_Payee;        // DE98: Payee (ans25)
  public string de99_SettleInstIdCode;        // DE99: Setl inst id code (n11)
  public string de100_RecvInstIdCode;        // DE100: Recv inst id code (n11)
  public string de101_FileName;        // DE101: File name (normally ans) (an17)
  public byte[] de102_AcctId1;        // DE102: Account id 1 (ans28 )
  public byte[] de103_AcctId2;        // DE103: Account id 2 (ans28 )
  public byte[] de104_TxnDesc;        // DE104: Txn description (ans100)
  public byte[] de105_ResvIso;        // DE105: Reserved for iso use (ans999)
  public byte[] de106_ResvIso;        // DE106: Reserved for iso use (ans999)
  public byte[] de107_ResvIso;        // DE107: Reserved for iso use (ans999)
  public byte[] de108_ResvIso;        // DE108: Reserved for iso use (ans999)
  public byte[] de109_ResvIso;        // DE109: Reserved for iso use (ans999)
  public byte[] de110_ResvIso;        // DE110: Reserved for iso use (ans999)
  public byte[] de111_ResvIso;        // DE111: Reserved for iso use (ans999)
  public byte[] de112_ResvNat;        // DE112: Reserved for national use (ans999)
  public byte[] de113_ResvNat;        // DE113: Reserved for national use (ans999)
  public byte[] de114_ResvNat;        // DE114: Reserved for national use (ans999)
  public byte[] de115_ResvNat;        // DE115: Reserved for national use (ans999)
  public byte[] de116_ResvNat;        // DE116: Reserved for national use (ans999)
  public string de117_CardStatUpdCode;        // DE117: Card status update code (oz only) (an2)
  public string de118_TotalCashNo;        // DE118: Cash, total number oz only (n10)
  public string de119_TotalCashAmt;        // DE119: Cash, total amount oz only (n16)
  public byte[] de120_ResvPriv;        // DE120: Reserved for private use (ans999)
  public byte[] de121_ResvPriv;        // DE121: Reserved for private use (ans999)
  public byte[] de122_ResvPriv;        // DE122: Reserved for private use (ans999)
  public byte[] de123_ResvPriv;        // DE123: Reserved for private use (ans999)
  public byte[] de124_ResvPriv;        // DE124: Reserved for private use (ans999)
  public byte[] de125_ResvPriv;        // DE125: Reserved for private use (ans999)
  public byte[] de126_ResvPriv;        // DE126: Reserved for private use (ans999)
  public byte[] de127_ResvPriv;        // DE127: Reserved for private use (ans999)
  public byte[] de128_MAC;        // DE128: MAC (b64)
  #endregion

  #region Parser
  /// <summary>
  /// Creates an As2805Message object by parsing the given message.
  /// The message should start with the first 2 bytes of the MTI.
  /// </summary>
  public As2805Message(byte[] buf)
  {
    // Read the header fields
    mti =
      (buf[0] >> 4) * 1000 +
      (buf[0] & 0xf) * 100 +
      (buf[1] >> 4) * 10 +
      (buf[1] & 0xf);
    primaryBitmap = B(buf, 2, 8 );

    // This keeps track of how much of the buffer we've read so far
    int offset = 10;

    // Read the fields according to which ones are set in the bitmap
    if ((primaryBitmap[0] & 128 ) > 0) de1_SecondaryBitmap = ReadFixRaw(buf, ref offset, 8 );
    if ((primaryBitmap[0] & 64) > 0) de2_PAN = ReadVar2Packed(buf, ref offset, 19);
    if ((primaryBitmap[0] & 32) > 0) de3_ProcCode = ReadFixPacked(buf, ref offset, 6);
    if ((primaryBitmap[0] & 16) > 0) de4_AmtTxn = ReadFixPacked(buf, ref offset, 12);
    if ((primaryBitmap[0] & 8 ) > 0) de5_AmtSettle = ReadFixPacked(buf, ref offset, 12);
    if ((primaryBitmap[0] & 4) > 0) de6_AmtCardhBill = ReadFixPacked(buf, ref offset, 12);
    if ((primaryBitmap[0] & 2) > 0) de7_TransDttm = ReadFixPacked(buf, ref offset, 10);
    if ((primaryBitmap[0] & 1) > 0) de8_AmtCardhBillFee = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[1] & 128 ) > 0) de9_ConvRateSettle = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[1] & 64) > 0) de10_ConvRateCardhBill = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[1] & 32) > 0) de11_STAN = ReadFixPacked(buf, ref offset, 6);
    if ((primaryBitmap[1] & 16) > 0) de12_TimeLocal = ReadFixPacked(buf, ref offset, 6);
    if ((primaryBitmap[1] & 8 ) > 0) de13_DateLocal = ReadFixPacked(buf, ref offset, 4);
    if ((primaryBitmap[1] & 4) > 0) de14_DateExpiry = ReadFixPacked(buf, ref offset, 4);
    if ((primaryBitmap[1] & 2) > 0) de15_DateSetl = ReadFixPacked(buf, ref offset, 4);
    if ((primaryBitmap[1] & 1) > 0) de16_DateConv = ReadFixPacked(buf, ref offset, 4);
    if ((primaryBitmap[2] & 128 ) > 0) de17_DateCapt = ReadFixPacked(buf, ref offset, 4);
    if ((primaryBitmap[2] & 64) > 0) de18_MerchType = ReadFixPacked(buf, ref offset, 4);
    if ((primaryBitmap[2] & 32) > 0) de19_AcqInstCtryCode = ReadFixPacked(buf, ref offset, 3);
    if ((primaryBitmap[2] & 16) > 0) de20_PriAccNumExtCtryCode = ReadFixPacked(buf, ref offset, 3);
    if ((primaryBitmap[2] & 8 ) > 0) de21_FwdInstCtryCode = ReadFixPacked(buf, ref offset, 3);
    if ((primaryBitmap[2] & 4) > 0) de22_PosEntryMode = ReadFixPacked(buf, ref offset, 3);
    if ((primaryBitmap[2] & 2) > 0) de23_CardSeqNo = ReadFixPacked(buf, ref offset, 3);
    if ((primaryBitmap[2] & 1) > 0) de24_NetIntlId = ReadFixPacked(buf, ref offset, 3);
    if ((primaryBitmap[3] & 128 ) > 0) de25_PosCondCode = ReadFixPacked(buf, ref offset, 2);
    if ((primaryBitmap[3] & 64) > 0) de26_PosPinCaptCode = ReadFixPacked(buf, ref offset, 2);
    if ((primaryBitmap[3] & 32) > 0) de27_AuthIdRespLen = ReadFixPacked(buf, ref offset, 1);
    if ((primaryBitmap[3] & 16) > 0) de28_AmtTxnFee = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[3] & 8 ) > 0) de29_AmtSettleFee = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[3] & 4) > 0) de30_AmtTxnProcFee = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[3] & 2) > 0) de31_AmtSettleProcFee = ReadFixPacked(buf, ref offset, 8 );
    if ((primaryBitmap[3] & 1) > 0) de32_AcqInstIdCode = ReadVar2Packed(buf, ref offset, 11);
    if ((primaryBitmap[4] & 128 ) > 0) de33_FwdInstIdCode = ReadVar2Packed(buf, ref offset, 11);
    if ((primaryBitmap[4] & 64) > 0) de34_PanExt = S(ReadVar2Raw(buf, ref offset, 28 ));
    if ((primaryBitmap[4] & 32) > 0) de35_Track2 = ReadVar2Raw(buf, ref offset, 37);
    if ((primaryBitmap[4] & 16) > 0) de36_Track3 = ReadVar3Raw(buf, ref offset, 104);
    if ((primaryBitmap[4] & 8 ) > 0) de37_RetRefNo = S(ReadFixRaw(buf, ref offset, 12));
    if ((primaryBitmap[4] & 4) > 0) de38_AuthIdentResp = S(ReadFixRaw(buf, ref offset, 6));
    if ((primaryBitmap[4] & 2) > 0) de39_RespCode = S(ReadFixRaw(buf, ref offset, 2));
    if ((primaryBitmap[4] & 1) > 0) de40_ServRestrCode = S(ReadFixRaw(buf, ref offset, 3));
    if ((primaryBitmap[5] & 128 ) > 0) de41_CardAcptTermId = S(ReadFixRaw(buf, ref offset, 8 ));
    if ((primaryBitmap[5] & 64) > 0) de42_CardAcptIdCode = S(ReadFixRaw(buf, ref offset, 15));
    if ((primaryBitmap[5] & 32) > 0) de43_CardAcptNameLoc = S(ReadFixRaw(buf, ref offset, 40));
    if ((primaryBitmap[5] & 16) > 0) de44_AddtRespData = ReadVar2Raw(buf, ref offset, 25);
    if ((primaryBitmap[5] & 8 ) > 0) de45_Track1 = ReadVar2Raw(buf, ref offset, 76);
    if ((primaryBitmap[5] & 4) > 0) de46_AddtlDataIso = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[5] & 2) > 0) de47_AddtlDataNat = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[5] & 1) > 0) de48_AddtlDataPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[6] & 128 ) > 0) de49_CurCodeTxn = S(ReadFixRaw(buf, ref offset, 3));
    if ((primaryBitmap[6] & 64) > 0) de50_CurCodeSettle = S(ReadFixRaw(buf, ref offset, 3));
    if ((primaryBitmap[6] & 32) > 0) de51_CurCodeCardhBill = S(ReadFixRaw(buf, ref offset, 3));
    if ((primaryBitmap[6] & 16) > 0) de52_PinData = ReadFixRaw(buf, ref offset, 8 );
    if ((primaryBitmap[6] & 8 ) > 0) de53_SecControlInfo = ReadFixPacked(buf, ref offset, 16);
    if ((primaryBitmap[6] & 4) > 0) de54_AddtlAmts = S(ReadVar3Raw(buf, ref offset, 120));
    if ((primaryBitmap[6] & 2) > 0) de55_ResIso = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[6] & 1) > 0) de56_ResIso = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[7] & 128 ) > 0) de57_AmtCash = ReadFixPacked(buf, ref offset, 12);
    if ((primaryBitmap[7] & 64) > 0) de58_BalanceLedger = ReadFixPacked(buf, ref offset, 12);
    if ((primaryBitmap[7] & 32) > 0) de59_BalanceCleared = ReadFixPacked(buf, ref offset, 12);
    if ((primaryBitmap[7] & 16) > 0) de60_PreswipeStatus = S(ReadVar3Raw(buf, ref offset, 1));
    if ((primaryBitmap[7] & 8 ) > 0) de61_ResPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[7] & 4) > 0) de62_ResPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[7] & 2) > 0) de63_ResPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((primaryBitmap[7] & 1) > 0) de64_MAC = ReadFixRaw(buf, ref offset, 8 );
    if ((de1_SecondaryBitmap[0] & 128 ) > 0) de65_Bitmap = ReadFixRaw(buf, ref offset, 8 );
    if ((de1_SecondaryBitmap[0] & 64) > 0) de66_SettleCode = ReadFixPacked(buf, ref offset, 1);
    if ((de1_SecondaryBitmap[0] & 32) > 0) de67_ExtPayCode = ReadFixPacked(buf, ref offset, 2);
    if ((de1_SecondaryBitmap[0] & 16) > 0) de68_RecvInstCtryCode = ReadFixPacked(buf, ref offset, 3);
    if ((de1_SecondaryBitmap[0] & 8 ) > 0) de69_SettleInstCtryCode = ReadFixPacked(buf, ref offset, 3);
    if ((de1_SecondaryBitmap[0] & 4) > 0) de70_NetMgtInfoCode = ReadFixPacked(buf, ref offset, 3);
    if ((de1_SecondaryBitmap[0] & 2) > 0) de71_MessageNo = ReadFixPacked(buf, ref offset, 4);
    if ((de1_SecondaryBitmap[0] & 1) > 0) de72_MessageNoLast = ReadFixPacked(buf, ref offset, 4);
    if ((de1_SecondaryBitmap[1] & 128 ) > 0) de73_DateAction = ReadFixPacked(buf, ref offset, 6);
    if ((de1_SecondaryBitmap[1] & 64) > 0) de74_CreditsNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[1] & 32) > 0) de75_CreditRevsNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[1] & 16) > 0) de76_DebitsNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[1] & 8 ) > 0) de77_DebitRevsNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[1] & 4) > 0) de78_TransfersNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[1] & 2) > 0) de79_TransferRevsNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[1] & 1) > 0) de80_InquiriesNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[2] & 128 ) > 0) de81_AuthsNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[2] & 64) > 0) de82_CreditsProcFeeAmt = ReadFixPacked(buf, ref offset, 12);
    if ((de1_SecondaryBitmap[2] & 32) > 0) de83_CreditsTxnFeeAmt = ReadFixPacked(buf, ref offset, 12);
    if ((de1_SecondaryBitmap[2] & 16) > 0) de84_DebitsProcFeeAmt = ReadFixPacked(buf, ref offset, 12);
    if ((de1_SecondaryBitmap[2] & 8 ) > 0) de85_DebitsTxnFeeAmt = ReadFixPacked(buf, ref offset, 12);
    if ((de1_SecondaryBitmap[2] & 4) > 0) de86_CreditsAmt = ReadFixPacked(buf, ref offset, 16);
    if ((de1_SecondaryBitmap[2] & 2) > 0) de87_CreditRevsAmt = ReadFixPacked(buf, ref offset, 16);
    if ((de1_SecondaryBitmap[2] & 1) > 0) de88_DebitsAmt = ReadFixPacked(buf, ref offset, 16);
    if ((de1_SecondaryBitmap[3] & 128 ) > 0) de89_DebitRevsAmt = ReadFixPacked(buf, ref offset, 16);
    if ((de1_SecondaryBitmap[3] & 64) > 0) de90_OrigDataElem = ReadFixPacked(buf, ref offset, 42);
    if ((de1_SecondaryBitmap[3] & 32) > 0) de91_FileUpdateCode = S(ReadFixRaw(buf, ref offset, 1));
    if ((de1_SecondaryBitmap[3] & 16) > 0) de92_FileSecCode = S(ReadFixRaw(buf, ref offset, 2));
    if ((de1_SecondaryBitmap[3] & 8 ) > 0) de93_RespInd = S(ReadFixRaw(buf, ref offset, 5));
    if ((de1_SecondaryBitmap[3] & 4) > 0) de94_ServInd = S(ReadFixRaw(buf, ref offset, 7));
    if ((de1_SecondaryBitmap[3] & 2) > 0) de95_ReplAmts = S(ReadFixRaw(buf, ref offset, 42));
    if ((de1_SecondaryBitmap[3] & 1) > 0) de96_MsgSecCode = ReadFixRaw(buf, ref offset, 8 );
    if ((de1_SecondaryBitmap[4] & 128 ) > 0) de97_AmtNetSetl = ReadFixPacked(buf, ref offset, 16);
    if ((de1_SecondaryBitmap[4] & 64) > 0) de98_Payee = ReadVar2Raw(buf, ref offset, 25);
    if ((de1_SecondaryBitmap[4] & 32) > 0) de99_SettleInstIdCode = ReadVar2Packed(buf, ref offset, 11);
    if ((de1_SecondaryBitmap[4] & 16) > 0) de100_RecvInstIdCode = ReadVar2Packed(buf, ref offset, 11);
    if ((de1_SecondaryBitmap[4] & 8 ) > 0) de101_FileName = S(ReadVar2Raw(buf, ref offset, 17));
    if ((de1_SecondaryBitmap[4] & 4) > 0) de102_AcctId1 = ReadVar2Raw(buf, ref offset, 28 );
    if ((de1_SecondaryBitmap[4] & 2) > 0) de103_AcctId2 = ReadVar2Raw(buf, ref offset, 28 );
    if ((de1_SecondaryBitmap[4] & 1) > 0) de104_TxnDesc = ReadVar3Raw(buf, ref offset, 100);
    if ((de1_SecondaryBitmap[5] & 128 ) > 0) de105_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 64) > 0) de106_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 32) > 0) de107_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 16) > 0) de108_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 8 ) > 0) de109_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 4) > 0) de110_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 2) > 0) de111_ResvIso = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[5] & 1) > 0) de112_ResvNat = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[6] & 128 ) > 0) de113_ResvNat = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[6] & 64) > 0) de114_ResvNat = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[6] & 32) > 0) de115_ResvNat = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[6] & 16) > 0) de116_ResvNat = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[6] & 8 ) > 0) de117_CardStatUpdCode = S(ReadFixRaw(buf, ref offset, 2));
    if ((de1_SecondaryBitmap[6] & 4) > 0) de118_TotalCashNo = ReadFixPacked(buf, ref offset, 10);
    if ((de1_SecondaryBitmap[6] & 2) > 0) de119_TotalCashAmt = ReadFixPacked(buf, ref offset, 16);
    if ((de1_SecondaryBitmap[6] & 1) > 0) de120_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 128 ) > 0) de121_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 64) > 0) de122_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 32) > 0) de123_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 16) > 0) de124_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 8 ) > 0) de125_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 4) > 0) de126_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 2) > 0) de127_ResvPriv = ReadVar3Raw(buf, ref offset, 999);
    if ((de1_SecondaryBitmap[7] & 1) > 0) de128_MAC = ReadFixRaw(buf, ref offset, 8 );
  }
  #endregion

  /// <summary>
  /// Format the fields as a nice string using reflection
  /// </summary>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    foreach (FieldInfo i in this.GetType().GetFields())
    {
      object val = i.GetValue(this);
      if (val != null)
      {
        if (val is byte[])
          sb.AppendFormat("{0}: {1}\r\n", i.Name, BitConverter.ToString((byte[])val));
        else
          sb.AppendFormat("{0}: {1}\r\n", i.Name, val);
      }
    }
    return sb.ToString();
  }

  #region Internal helpers
  /// <summary>
  /// Converts 0-15 to '0-9A-F'
  /// </summary>
  char XtoC(int x)
  {
    if (x < 10) return (char)('0' + x);
    return (char)('A' + x);
  }

  /// <summary>
  /// Grab bytes from a buffer
  /// </summary>
  byte[] B(byte[] buf, int off, int len)
  {
    byte[] a = new byte[len];
    Array.Copy(buf, off, a, 0, len);
    return a;
  }

  /// <summary>
  /// Converts a buffer to a string
  /// </summary>
  string S(byte[] buf)
  {
    return Encoding.ASCII.GetString(buf);
  }
    
  byte[] ReadFixRaw(byte[] buf, ref int offset, int len)
  {
    byte[] val = B(buf, offset, len);
    offset += len;
    return val;
  }

  byte[] ReadVar2Raw(byte[] buf, ref int offset, int unused)
  {
    int len = (buf[offset] - 0x30) * 10 + buf[offset + 1] - 0x30;
    int oldoffset = offset;
    offset += len + 2;
    return B(buf, oldoffset + 2, len);
  }

  byte[] ReadVar3Raw(byte[] buf, ref int offset, int unused)
  {
    int len = (buf[offset]-0x30)*100 + (buf[offset+1]-0x30)*10 + buf[offset+2]-0x30;
    int oldoffset = offset;
    offset += len + 3;
    return B(buf, oldoffset + 3, len);
  }

  /// <summary>
  /// Reads an LLVARn
  /// eg input: 31 31 12 34 56 78 91 2F
  /// 31 31 is ascii '11' which means 11 numbers
  /// Those 11 numbers are binary packed decimal = 1234567891
  /// The 'F' at the end is filler.
  /// </summary>
  string ReadVar2Packed(byte[] buf, ref int offset, int unused)
  {
    int len = (buf[offset] - 0x30) * 10 + (buf[offset + 1] - 0x30);
    int bytes = (len + 1) / 2; // The +1 is so it rounds up
    byte b;
    StringBuilder sb = new StringBuilder(len);
    if (len % 2 == 0) // Even number of chars, so there's no padding at the end
    {
      for (int i = 0; i < bytes; i++)
      {
        b = buf[offset + 2 + i];
        sb.Append(XtoC(b >> 4)).Append(XtoC(b & 0xf));
      }
    }
    else
    {
      int i;
      for (i = 0; i < bytes - 1; i++)
      {
        b = buf[offset + 2 + i];
        sb.Append(XtoC(b >> 4)).Append(XtoC(b & 0xf));
      }
      sb.Append(XtoC(buf[offset + 2 + i] >> 4)); // Get the last char
    }
    offset += bytes + 2;
    return sb.ToString();
  }

  /// <summary>
  /// Reads an LLLVARn
  /// eg input: 30 31 31 12 34 56 78 91 2F
  /// 30 31 31 is ascii '011' which means 11 numbers
  /// Those 11 numbers are binary packed decimal = 1234567891
  /// The 'F' at the end is filler.
  /// </summary>
  string ReadVar3Packed(byte[] buf, ref int offset, int unused)
  {
    int len = (buf[offset] - 0x30) * 100 + (buf[offset + 1] - 0x30) * 10 + (buf[offset + 2] - 0x30);
    int bytes = (len + 1) / 2; // The +1 is so it rounds up
    byte b;
    StringBuilder sb = new StringBuilder(len);
    if (len % 2 == 0) // Even number of chars, so there's no padding at the end
    {
      for (int i = 0; i < bytes; i++)
      {
        b = buf[offset + 3 + i];
        sb.Append(XtoC(b >> 4)).Append(XtoC(b & 0xf));
      }
    }
    else
    {
      int i;
      for (i = 0; i < bytes - 1; i++)
      {
        b = buf[offset + 3 + i];
        sb.Append(XtoC(b >> 4)).Append(XtoC(b & 0xf));
      }
      sb.Append(XtoC(buf[offset + 3 + i] >> 4)); // Get the last char
    }
    offset += bytes + 3;
    return sb.ToString();
  }

  /// <summary>
  /// Parse a fixed length packed [hexi]decimal field
  /// If it is an odd number of digits, it skips the first nibble
  /// eg for input 0x01 23 of length 3, it grabs the "123"
  /// </summary>
  string ReadFixPacked(byte[] buf, ref int offset, int len)
  {
    int bytes = (len + 1) / 2; // The +1 is so it rounds up
    byte b;
    StringBuilder sb = new StringBuilder(len);
    if (len % 2 == 0) // Even number of chars, so there's no padding at the end
    {
      for (int i = 0; i < bytes; i++)
      {
        b = buf[offset + i];
        sb.Append(XtoC(b >> 4)).Append(XtoC(b & 0xf));
      }
    }
    else // Odd number
    {
      int i;
      sb.Append(XtoC(buf[offset] & 0xf)); // Get the first char from the second nibble
      for (i = 1; i < bytes; i++)
      {
        b = buf[offset + i];
        sb.Append(XtoC(b >> 4)).Append(XtoC(b & 0xf));
      }
    }
    offset += bytes;
    return sb.ToString();
  }
  #endregion
}
And here's example code to use it:
using System;

class Program
{
  static void Main(string[] args)
  {
    // Raw bytes for an AS2805 message
    byte[] message = new byte[] {
      0x02, 0x00,
      0x80, 0x38, 0x00, 0x01, 0x02, 0xC1, 0x00, 0x00,
      0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
      0x65, 0x43, 0x21,
      0x13, 0x58, 0x40,
      0x04, 0x19,
      0x31, 0x31, 0x00, 0x08, 0x76, 0x54, 0x32, 0x1F,
      0x30, 0x30,
      0x38, 0x34, 0x30, 0x37, 0x31, 0x32, 0x33, 0x34,
      0x37, 0x37, 0x37, 0x30, 0x30, 0x30, 0x31, 0x32, 0x33, 0x32, 0x31, 0x32, 0x33, 0x32, 0x31,
      0x30, 0x30, 0x38,
      0x8C, 0xA0, 0xA6, 0x42, 0x0C, 0x5C, 0xA6, 0x28,
      0x01, 0x23};

    // Parse the bytes into an instance of the message class
    As2805Message m = new As2805Message(message);
    // Display the parsed fields
    Console.WriteLine(m.ToString());

    Console.WriteLine("Press a key");
    Console.ReadKey();
  }
}