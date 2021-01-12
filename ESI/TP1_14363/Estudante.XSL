<?xml version="1.0" encoding="utf-8"?>
<!--
by Adaptada Jeremy Morgan
by Tutorialspoint
-->
xsl:stylesheet version="1.0" 
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
 <xsl:output method="html" encoding="iso-8859-1"/>
  <xsl:template match="/">
        <html>      
      <body>        
        <table>  Estudante  </table>
                <table border= "1">
                   <xsl:apply-templates select="Rows"/>
                </table>
            </body> 
        </html>
    </xsl:template>
  
  <xsl:template match="Rows">
    <xsl:for-each select ="Row">
              <xsl:if test="position()=1">
          <xsl:attribute name="bgcolor">red</xsl:attribute>
          <tr>
            <xsl:for-each select="./*">
              <td>
                <xsl:value-of select="name()"/>
              </td>
            </xsl:for-each>
          </tr>
        </xsl:if>
      <tr>
        <xsl:if test="position() mod 2 =0">
					<xsl:attribute name="bgcolor">Red</xsl:attribute>
				</xsl:if>
				<xsl:if test="position() mod 2 !=0">
					<xsl:attribute name="bgcolor">White</xsl:attribute>
				</xsl:if>
        <xsl:for-each select="*">
          <td>
              <xsl:value-of select="./text()"/>
          </td>
        </xsl:for-each>
      </tr>
    </xsl:for-each>
  </xsl:template>
  </xsl:stylesheet>
