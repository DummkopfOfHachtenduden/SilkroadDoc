1   byte    noticeCount
foreach(notice)
{
    2   ushort  notice.Subject.Length
    *   string  notice.Subject
    2   ushort  notice.Article.Length
    *   string  notice.Article
    2   ushort  notice.EditDate.Year
    2   ushort  notice.EditDate.Month
    2   ushort  notice.EditDate.Day
    2   ushort  notice.EditDate.Hour
    2   ushort  notice.EditDate.Minute
    2   ushort  notice.EditDate.Second
    4   uint    notice.EditDate.Microsecond
}