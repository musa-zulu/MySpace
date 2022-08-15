using ErrorOr;

namespace MySpace.Domain.Common;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Conflict(code: "User.DuplicateEmail",
                                                             description: "Email already exists.");
    }
}