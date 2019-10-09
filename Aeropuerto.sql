USE [Aeropuerto]
GO
/****** Object:  Table [dbo].[AE_BOLETOS_AVION]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_BOLETOS_AVION](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cod_vuelo] [int] NOT NULL,
	[precio] [decimal](18, 0) NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_BOLET__3213E83FCADA27D7] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_CLASE]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_CLASE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[desc_clase] [varchar](1000) NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_CLASE__3213E83FD8FD9A5A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_COMPANIA]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_COMPANIA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[desc_compania] [varchar](1000) NULL,
	[telefono] [int] NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_COMPA__3213E83F77D1989A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_ESCALAS_VUELOS]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_ESCALAS_VUELOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cod_vuelo] [int] NOT NULL,
	[cod_pais] [int] NOT NULL,
	[duracion_escala] [varchar](50) NULL,
	[fec_vuelo] [date] NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_ESCAL__3213E83F10DB785A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_PAGO_BOLETO]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_PAGO_BOLETO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[comprobante] [int] NOT NULL,
	[cod_reserva] [int] NOT NULL,
	[monto_boleto] [decimal](18, 0) NULL,
	[impuesto] [int] NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_PAGO___3213E83F9E03FBC7] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_PAISES]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_PAISES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[desc_pais] [varchar](1000) NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_PAISE__3213E83F5B34C241] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_PASAJEROS]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_PASAJEROS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[identificacion] [varchar](50) NOT NULL,
	[nombre] [varchar](1000) NULL,
	[pasaporte] [int] NULL,
	[visa] [int] NULL,
	[fec_nacimiento] [date] NULL,
	[correo_electronico] [varchar](1000) NULL,
	[telefono] [int] NULL,
	[cod_estado] [int] NULL,
 CONSTRAINT [PK__AE_PASAJ__3213E83F20A40CFF] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_RESERVA_BOLETO]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_RESERVA_BOLETO](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cod_boleto] [int] NOT NULL,
	[cod_pasajero] [int] NOT NULL,
	[cod_clase] [int] NOT NULL,
	[num_asiento] [varchar](5) NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_RESER__3213E83FE9655F7F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_TIPOS_AVIONES]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_TIPOS_AVIONES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[desc_avion] [varchar](1000) NULL,
	[ind_estado] [varchar](5) NULL,
	[asientos] [int] NULL,
 CONSTRAINT [PK__AE_TIPOS__3213E83F701A1FCA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AE_VUELOS]    Script Date: 08/10/2019 18:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AE_VUELOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cod_compania] [int] NOT NULL,
	[cod_pais_abordaje] [int] NOT NULL,
	[cod_pais_destino] [int] NOT NULL,
	[cod_avion] [int] NOT NULL,
	[duracion] [varchar](50) NULL,
	[fec_vuelo] [date] NULL,
	[fec_salida] [datetime] NULL,
	[fec_entrada] [datetime] NULL,
	[ind_estado] [varchar](5) NULL,
 CONSTRAINT [PK__AE_VUELO__3213E83FECCBC2D9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AE_BOLETOS_AVION]  WITH CHECK ADD  CONSTRAINT [FK_AE_BOLETOS_AVION_AE_VUELOS] FOREIGN KEY([cod_vuelo])
REFERENCES [dbo].[AE_VUELOS] ([id])
GO
ALTER TABLE [dbo].[AE_BOLETOS_AVION] CHECK CONSTRAINT [FK_AE_BOLETOS_AVION_AE_VUELOS]
GO
ALTER TABLE [dbo].[AE_ESCALAS_VUELOS]  WITH CHECK ADD  CONSTRAINT [FK_AE_ESCALAS_VUELOS_AE_PAISES] FOREIGN KEY([cod_pais])
REFERENCES [dbo].[AE_PAISES] ([id])
GO
ALTER TABLE [dbo].[AE_ESCALAS_VUELOS] CHECK CONSTRAINT [FK_AE_ESCALAS_VUELOS_AE_PAISES]
GO
ALTER TABLE [dbo].[AE_ESCALAS_VUELOS]  WITH CHECK ADD  CONSTRAINT [FK_AE_ESCALAS_VUELOS_AE_VUELOS] FOREIGN KEY([cod_vuelo])
REFERENCES [dbo].[AE_VUELOS] ([id])
GO
ALTER TABLE [dbo].[AE_ESCALAS_VUELOS] CHECK CONSTRAINT [FK_AE_ESCALAS_VUELOS_AE_VUELOS]
GO
ALTER TABLE [dbo].[AE_PAGO_BOLETO]  WITH CHECK ADD  CONSTRAINT [FK_AE_PAGO_BOLETO_AE_RESERVA_BOLETO] FOREIGN KEY([cod_reserva])
REFERENCES [dbo].[AE_RESERVA_BOLETO] ([id])
GO
ALTER TABLE [dbo].[AE_PAGO_BOLETO] CHECK CONSTRAINT [FK_AE_PAGO_BOLETO_AE_RESERVA_BOLETO]
GO
ALTER TABLE [dbo].[AE_RESERVA_BOLETO]  WITH CHECK ADD  CONSTRAINT [FK_AE_RESERVA_BOLETO_AE_BOLETOS_AVION] FOREIGN KEY([cod_boleto])
REFERENCES [dbo].[AE_BOLETOS_AVION] ([id])
GO
ALTER TABLE [dbo].[AE_RESERVA_BOLETO] CHECK CONSTRAINT [FK_AE_RESERVA_BOLETO_AE_BOLETOS_AVION]
GO
ALTER TABLE [dbo].[AE_RESERVA_BOLETO]  WITH CHECK ADD  CONSTRAINT [FK_AE_RESERVA_BOLETO_AE_CLASE] FOREIGN KEY([cod_clase])
REFERENCES [dbo].[AE_CLASE] ([id])
GO
ALTER TABLE [dbo].[AE_RESERVA_BOLETO] CHECK CONSTRAINT [FK_AE_RESERVA_BOLETO_AE_CLASE]
GO
ALTER TABLE [dbo].[AE_RESERVA_BOLETO]  WITH CHECK ADD  CONSTRAINT [FK_AE_RESERVA_BOLETO_AE_PASAJEROS] FOREIGN KEY([cod_pasajero])
REFERENCES [dbo].[AE_PASAJEROS] ([id])
GO
ALTER TABLE [dbo].[AE_RESERVA_BOLETO] CHECK CONSTRAINT [FK_AE_RESERVA_BOLETO_AE_PASAJEROS]
GO
ALTER TABLE [dbo].[AE_VUELOS]  WITH CHECK ADD  CONSTRAINT [FK_AE_VUELOS_AE_COMPANIA] FOREIGN KEY([cod_compania])
REFERENCES [dbo].[AE_COMPANIA] ([id])
GO
ALTER TABLE [dbo].[AE_VUELOS] CHECK CONSTRAINT [FK_AE_VUELOS_AE_COMPANIA]
GO
ALTER TABLE [dbo].[AE_VUELOS]  WITH CHECK ADD  CONSTRAINT [FK_AE_VUELOS_AE_PAISES] FOREIGN KEY([cod_pais_abordaje])
REFERENCES [dbo].[AE_PAISES] ([id])
GO
ALTER TABLE [dbo].[AE_VUELOS] CHECK CONSTRAINT [FK_AE_VUELOS_AE_PAISES]
GO
ALTER TABLE [dbo].[AE_VUELOS]  WITH CHECK ADD  CONSTRAINT [FK_AE_VUELOS_AE_PAISES1] FOREIGN KEY([cod_pais_destino])
REFERENCES [dbo].[AE_PAISES] ([id])
GO
ALTER TABLE [dbo].[AE_VUELOS] CHECK CONSTRAINT [FK_AE_VUELOS_AE_PAISES1]
GO
ALTER TABLE [dbo].[AE_VUELOS]  WITH CHECK ADD  CONSTRAINT [FK_AE_VUELOS_AE_TIPOS_AVIONES] FOREIGN KEY([cod_avion])
REFERENCES [dbo].[AE_TIPOS_AVIONES] ([id])
GO
ALTER TABLE [dbo].[AE_VUELOS] CHECK CONSTRAINT [FK_AE_VUELOS_AE_TIPOS_AVIONES]
GO
