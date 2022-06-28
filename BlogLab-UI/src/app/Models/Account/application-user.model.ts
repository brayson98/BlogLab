export class ApplicationUser {
  constructor(
    public applicatoinUserId: number,
    public username: string,
    public fullname: string,
    public email: string,
    public token: string
  ) {}
}
