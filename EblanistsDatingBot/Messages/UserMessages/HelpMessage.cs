﻿namespace EblanistsDatingBot.Messages.UserMessages;

public class HelpMessage : BaseMessage
{
    public override string MessageText =>
        "/start - run hari\n" +
        "/dating - view profiles of other users\n" +
        "/requests - chat requests\n" +
        "/profile - go to profile\n" +
        "/view_photos - my photo album\n" +
        "/delete_profile - delete profile\n" +
        "/feedback - contact us\n" +
        "/help - command list";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithUrl(text: "write to support 💬", url: "http://t.me/hari_admin")
        },
    });
}
