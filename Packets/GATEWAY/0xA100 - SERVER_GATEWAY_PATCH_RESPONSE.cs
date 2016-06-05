//Massive
1	byte	result
if(result == 0x02)
{
	1	byte	errorCode
	if(errorCode == 0x02)
	{
		2	ushort	DownloadServer.IP.Length
		*	string	DownloadServer.IP
		2	ushort	DownloadServer.Port
		4	uint	DownloadServer.CurVersion
		
		while(true)
		{
			1	bool isEOL
			if(isEOL)
				break;
			
			4	uint	file.ID
			2	ushort	file.Name.Length			
			*	string	file.Name
			2	ushort	file.Name.Length
			*	string	file.Name
			4	uint	file.Length //bytes
			1	bool	file.ToBePacked
		}		
	}
}