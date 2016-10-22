//CPU Disasm
//Address   Hex dump          Command                                               Comments
//008A4545  |. C74424 04 DFB4 MOV DWORD PTR SS:[ESP+4],0B4DF
//008A454D  |. C74424 08 10A3 MOV DWORD PTR SS:[ESP+8],sro_client.0089A310

1	byte	count
foreach(entry)
{
	1	byte	matchingUnionEntry
	1	byte	fromMonth
	1	byte	fromDay
	1	byte	fromHour
	1	byte	fromMinute
	1	byte	toMonth
	1	byte	toDay
	1	byte	toHour
	1	byte	toMinute
	4	uint	traderUnionPoints
	4	uint	thiefUnionPoints
}

public enum TAPEntryType : byte
{
	//Not possible.
	UIIT_STT_EGYPT_SHRINE_ENTRANCE_UNION_EMPTY = 0,

	//Thief Guild
	UIIT_PAG_COMPANY_THIEF = 2,

	//Show all
	UIIT_STT_EGYPT_SHRINE_ENTRANCE_UNION_ALL = 3,
}

//Temple area Point related
[S -> C][B4DF]
01                                                ................
04                                                ................

[S -> C][B4DF]
00                                                ................

//ANUBIS & ISIS
//sanctum of punishment/sunctum of Atonement
00                                                //Available union matching for entering

06                                                fromMonth
10                                                fromDay
07                                                fromHour
00                                                fromMinute
06                                                toMonth
11                                                toDay
07                                                toHour
00                                                toMinute
00 00 00 00                                       traderUnionPoints
00 00 00 00                                       thiefUnionPoints

//HAROERIS & SETH
//sanctum of Immortality/sanctum of Dark
00                                                ................

06                                                fromMonth
10                                                fromDay
07                                                fromHour
0A                                                fromMinute

06                                                toMonth
11                                                toDay
07                                                toHour
0A                                                toMinute
00 00 00 00                                       traderUnionPoints
00 00 00 00                                       thiefUnionPoints