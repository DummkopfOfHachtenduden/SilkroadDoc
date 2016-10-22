//CPU Disasm
//Address   Hex dump          Command                                                 Comments
//00822D48  |. 68 E0740000    PUSH 74E0                                               ; /Arg1 = 74E0
//00822D4D  |. 8D4C24 0C      LEA ECX,[ARG.3]                                         ; |
//700822D51  |. E8 4AA1D1FF    CALL sro_client.beginPacket                             ; \sro_client.beginPacket