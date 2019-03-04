export class LoginModel {
    public Email: string;
    public Password: string;

    constructor(email: string, pwd: string) {
        this.Email = email;
        this.Password = pwd;
    }
}
