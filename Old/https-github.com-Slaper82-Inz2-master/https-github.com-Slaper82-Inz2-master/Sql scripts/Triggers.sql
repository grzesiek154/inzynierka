--INŻYNIERKA TRIGGERy
CREATE TRIGGER [dbo].[PARY_TRANS]
ON [dbo].[rcpTransactionAll]
AFTER  INSERT
AS
	BEGIN
		IF (Select IdTransType from inserted)=1 and (select count(*) from rcpPairsIO where CONVERT(Date,Start)=CONVERT(Date,(Select DateAndTime from inserted)) and Stop is null)=0
				begin
					Insert into rcpPairsIO values((Select IdUser from inserted),(Select DateAndTime from inserted),null)
				end
	END
GO


CREATE TRIGGER [dbo].[PARY_TRANS_Out]
ON [dbo].[rcpTransactionAll]
AFTER  INSERT
AS
	BEGIN
		 if(Select IdTransType from inserted)=2 and (select count(*) from rcpPairsIO where CONVERT(Date,Start)=CONVERT(Date,(Select DateAndTime from inserted)) and [Stop] is null)=1
			begin
				declare @id as int set @id=(select IdUser from inserted)
				declare @dataWsad as Datetime set @dataWsad=(Select DateAndTime from inserted)
				declare @dataWej as Datetime set @dataWej=(Select top 1 Start from rcpPairsIO where CONVERT(Date,Start)=CONVERT(Date, @dataWsad) order by [Stop] desc)
				if(@dataWsad>@dataWej)
					Begin
						update rcpPairsIO 
						set	[Stop]=@dataWsad
						where IdUser=@id and Start=@dataWej
					End
			end 
	END
GO
